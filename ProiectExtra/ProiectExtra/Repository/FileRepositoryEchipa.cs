using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;
using ProiectExtra.Validator;

namespace ProiectExtra.Repository
{
    public class FileRepositoryEchipa : FileRepository<string, Echipa>
    {
        public FileRepositoryEchipa(IValidator<Echipa> validator, string numeFisier) : base(validator, numeFisier)
        {
        }
        public override Echipa extractEntity(String line)
        {
            string[] split = line.Split(";");
            Echipa entity = new Echipa(split[0], split[1]);
            return entity;
        }
    }
}
