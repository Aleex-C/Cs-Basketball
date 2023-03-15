using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;
using ProiectExtra.Validator;

namespace ProiectExtra.Repository
{
    public class FileRepositoryJucatorActiv : FileRepository<string, JucatorActiv>
    {
        public FileRepositoryJucatorActiv(IValidator<JucatorActiv> validator, string numeFisier) : base(validator, numeFisier)
        {
        }
        public override JucatorActiv extractEntity(String line)
        {
            string[] split = line.Split(";");
            JucatorActiv entity = new JucatorActiv(split[0], split[1], split[2], int.Parse(split[3]), (Tip)Enum.Parse(typeof(Tip), split[4]));
            return entity;
        }
    }
}
