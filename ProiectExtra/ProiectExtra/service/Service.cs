using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;
using ProiectExtra.Repository;

namespace ProiectExtra.service
{
    public class Service
    {
        private IRepository<string, Echipa> repoEchipa;
        private IRepository<string, Jucator> repoJucator;
        private IRepository<string, Meci> repoMeci;
        private IRepository<string, JucatorActiv> repoJucatorActiv;

        public Service(IRepository<string, Echipa> repository1, IRepository<string, Jucator> repository2, IRepository<string, Meci> repository3, IRepository<string, JucatorActiv> repository4)
        {
            repoEchipa = repository1;
            repoJucator = repository2;
            repoMeci = repository3;
            repoJucatorActiv = repository4;
        }
        public List<Jucator> JucatoriiUneiEchipe(string echipa)
        {
            return repoJucator.FindAll().Where(x => x.Echipa.Equals(echipa)).ToList();
        }
        public List<Jucator> JucatoriActiviMeci(string echipa1, string echipa2)
        {
            var rez = repoMeci.FindAll().Where(x => ((x.Echipa1 == echipa1 && x.Echipa2 == echipa2) || (x.Echipa1 == echipa2 && x.Echipa2 == echipa1))).Select(x => x.Id);
            if (rez.ToList().Count == 0)
                return null;
            string idMeci = rez.ToList<string>()[0];
            var query = from jucator in repoJucator.FindAll() //LINQ
                        join activ in repoJucatorActiv.FindAll()
                        on jucator.Id equals activ.IdJucator
                        where activ.IdMeci == idMeci && (jucator.Echipa == echipa1 || jucator.Echipa == echipa2)
                        select jucator;
            return query.ToList();
        }
        public List<Meci> MeciuriPerioada(DateTime dt1, DateTime dt2)
        {
            return repoMeci.FindAll().Where(x => (x.Data > dt1.AddDays(-1) && x.Data <= dt2)).ToList();
        }
        public string ScorMeci(string echipa1, string echipa2)
        {
            var rez = repoMeci.FindAll().Where(x => ((x.Echipa1 == echipa1 && x.Echipa2 == echipa2) || (x.Echipa1 == echipa2 && x.Echipa2 == echipa1))).Select(x => x.Id);
            if (rez.ToList().Count == 0)
                return null;
            string idMeci = rez.ToList<string>()[0];
            var rez1 = from jucator in repoJucator.FindAll()
                       join activ in repoJucatorActiv.FindAll()
                       on jucator.Id equals activ.IdJucator
                       where jucator.Echipa == echipa1 && activ.IdMeci == idMeci
                       select activ.NrPuncteInscrise;
            var scor1 = rez1.Sum();

            var rez2 = from jucator in repoJucator.FindAll()
                       join activ in repoJucatorActiv.FindAll()
                       on jucator.Id equals activ.IdJucator
                       where jucator.Echipa == echipa2 && activ.IdMeci == idMeci
                       select activ.NrPuncteInscrise;
            var scor2 = rez2.Sum();
            return scor1.ToString() + "-" + scor2.ToString();
        }

        public List<Echipa> Echipe()
        {
            return repoEchipa.FindAll().ToList();
        }
    }
}
