using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectExtra.Domain
{
    public class Elev : Entitate<string>
    {
        public string Nume { get; set; }
        public string Scoala { get; set; }
        public Elev(string id, string nume, string scoala) : base(id)
        {
            Nume = nume;
            Scoala = scoala;
        }
        public override string ToString()
        {
            return Id + " " + Nume + " " + Scoala;
        }
    }
}
