using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;

namespace ProiectExtra.Validator
{
    public class ValidatorJucatorActiv : IValidator<JucatorActiv>
    {
        public void Valideaza(JucatorActiv jucator)
        {
            if (jucator.NrPuncteInscrise < 0)
            {
                throw new ValidationException("Negative scored points!!!\n");
            }
        }
    }
}
