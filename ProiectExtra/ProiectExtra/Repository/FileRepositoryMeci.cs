using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;
using ProiectExtra.Validator;

namespace ProiectExtra.Repository
{
    public class FileRepositoryMeci : FileRepository<string, Meci>
    {
        public FileRepositoryMeci(IValidator<Meci> validator, string numeFisier) : base(validator, numeFisier)
        {
        }
        public override Meci extractEntity(String line)
        {
            string[] split = line.Split(";");
            Meci entity = new Meci(split[0], split[1], split[2], DateTime.Parse(split[3]));
            return entity;
        }
    }
}
