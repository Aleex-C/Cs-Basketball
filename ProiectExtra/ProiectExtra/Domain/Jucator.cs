using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectExtra.Domain
{
    public class Jucator : Elev
    {
        public string Echipa { get; set; }
        public Jucator(string id, string nume, string scoala, string echipa) : base(id, nume, scoala)
        {
            Echipa = echipa;
        }
        public override string ToString()
        {
            return base.ToString() + "-" + Echipa;
        }
    }
}
