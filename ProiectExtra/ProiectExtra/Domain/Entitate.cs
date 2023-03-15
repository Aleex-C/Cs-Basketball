using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectExtra.Domain
{
    public class Entitate<TID>
    {
        public TID Id { get; set; }

        public Entitate(TID id)
        {
            Id = id;
        }
    }
}
