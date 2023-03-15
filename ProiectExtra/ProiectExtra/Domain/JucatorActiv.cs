using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectExtra.Domain
{
    public enum Tip
    {
        Rezerva,
        Participant
    }
    public class JucatorActiv : Entitate<string>
    {
        public string IdJucator { get; set; }
        public string IdMeci { get; set; }
        public int NrPuncteInscrise { get; set; }
        public Tip TipJucator { get; set; }
        public JucatorActiv(string id, string idj, string idm, int nr, Tip t) : base(id)
        {
            IdJucator = idj;
            IdMeci = idm;
            NrPuncteInscrise = nr;
            TipJucator = t;
        }
        public override string ToString()
        {
            return Id + " " + IdJucator + " " + IdMeci + " " + NrPuncteInscrise.ToString() + " " + TipJucator;
        }
    }
}
