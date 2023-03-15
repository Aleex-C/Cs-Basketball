using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectExtra.Domain
{
    public class Meci : Entitate<string>
    {
        public string Echipa1 { get; set; }
        public string Echipa2 { get; set; }
        public DateTime Data { get; set; }
        public Meci(string id, string e1, string e2, DateTime dt) : base(id)
        {
            Echipa1 = e1;
            Echipa2 = e2;
            Data = dt;
        }
        public override string ToString()
        {
            return Id + " " + Echipa1 + " vs " + Echipa2 + " " + Data;
        }
    }
}
