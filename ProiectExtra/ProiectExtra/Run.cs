using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;
using ProiectExtra.Repository;
using ProiectExtra.service;
using ProiectExtra.Validator;
using ProiectExtra.UI;

namespace ProiectExtra
{
    public class Run
    {
        public static void run()
        {
            Service serv;
            IRepository<string, Echipa> repoEchipa =
                new FileRepositoryEchipa(new ValidatorEchipa(),
                    "F:\\Facultate\\MaP\\Facultativ\\ProiectExtra\\echipe.txt");

            IRepository<string, Jucator> repoJucator =
            new FileRepositoryJucator(new ValidatorJucator(),
                "F:\\Facultate\\MaP\\Facultativ\\ProiectExtra\\jucatori.txt");

            IRepository<string, Meci> repoMeci =
            new FileRepositoryMeci(new ValidatorMeci(),
                "F:\\Facultate\\MaP\\Facultativ\\ProiectExtra\\meciuri.txt");

            IRepository<string, JucatorActiv> repoJucatorActiv = new FileRepositoryJucatorActiv(new ValidatorJucatorActiv(), "F:\\Facultate\\MaP\\Facultativ\\ProiectExtra\\jucatoriActivi.txt");
            serv = new Service(repoEchipa, repoJucator, repoMeci, repoJucatorActiv);

            CNS uiRun = new CNS(serv);
            uiRun.run_ui();
        }
    }
}
