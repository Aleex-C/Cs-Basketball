using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;

namespace ProiectExtra.Repository
{
    public interface IRepository<ID, E> where E : Entitate<ID>
    {
        E FindOne(ID id);

        IEnumerable<E> FindAll();

        E Save(E e);
    }
}
