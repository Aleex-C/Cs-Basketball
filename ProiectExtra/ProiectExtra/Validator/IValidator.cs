using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectExtra.Validator
{
    public interface IValidator<E>
    {
        void Valideaza(E entitate);
    }
}
