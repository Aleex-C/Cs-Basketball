using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectExtra.Domain
{
    public class DelegatesParser
    {
        private static char Separator = ';';

        public static Echipa ParserEchipa(string line)
        {
            string[] split = line.Split(Separator);
            Echipa entity = new Echipa(split[0], split[1]);
            return entity;
        }
        public static Jucator ParserJucator(string line)
        {
            string[] split = line.Split(Separator);
            Jucator entity = new Jucator(split[0], split[1], split[2], split[3]);
            return entity;
        }
        public static Meci ParserMeci(string line)
        {
            string[] split = line.Split(Separator);
            Meci entity = new Meci(split[0], split[1], split[2], DateTime.Parse(split[3]));
            return entity;
        }
        public static JucatorActiv ParserJucatorActiv(string line)
        {
            string[] split = line.Split(Separator);
            JucatorActiv entity = new JucatorActiv(split[0], split[1], split[2], int.Parse(split[3]), (Tip)Enum.Parse(typeof(Tip), split[4]));
            return entity;
        }
    }
}
