using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;

namespace ProiectExtra.Validator
{
    public class ValidatorJucator : IValidator<Jucator>
    {
        public void Valideaza(Jucator jucator)
        {
            string str = "";
            if (jucator.Nume == null || jucator.Nume == "")
            {
                str = "Name null/blank\n";
            }
            if (jucator.Scoala == null || jucator.Scoala == "")
            {
                str += "School null/blank\n";
            }
            if (jucator.Echipa == null || jucator.Echipa == "")
            {
                str += "Team null/blank\n";
            }
            if (str != "")
                throw new ValidationException(str);
        }
    }
}
