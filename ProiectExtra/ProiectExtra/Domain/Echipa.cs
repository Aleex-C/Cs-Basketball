using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectExtra.Domain
{
    public class Echipa : Entitate<string>
    {
        public string Nume { get; set; }
        public Echipa(string id, string nume) : base(id)
        {
            Nume = nume;
        }
        public override string ToString()
        {
            return Id + " " + Nume;
        }
    }
}
