using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;

namespace ProiectExtra.Validator
{
    public class ValidatorEchipa : IValidator<Echipa>
    {
        public void Valideaza(Echipa echipa)
        {
            if (echipa.Nume == null || echipa.Nume == "")
            {
                throw new ValidationException("Name null/blank\n");
            }
        }
    }
}
