# Cs-Basketball
C# Basketball Tournament Manager

Layered Architecture, OOP Principles, file-hadnling in C#, Generics, Delegates

LINQ

` public List<Meci> MeciuriPerioada(DateTime dt1, DateTime dt2)
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
        }`
