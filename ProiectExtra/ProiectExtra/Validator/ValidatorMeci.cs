using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;

namespace ProiectExtra.Validator
{
    public class ValidatorMeci : IValidator<Meci>
    {
        public void Valideaza(Meci meci)
        {
            string str = "";
            if (meci.Echipa1 == null || meci.Echipa1 == "")
            {
                str = "Team 1 null\n";
            }
            if (meci.Echipa2 == null || meci.Echipa2 == "")
            {
                str += "Team 2 null\n";
            }
            if (meci.Data > DateTime.Now)
            {
                str += "Invalid date\n";
            }
            if (str != "")
                throw new ValidationException(str);
        }
    }
}
