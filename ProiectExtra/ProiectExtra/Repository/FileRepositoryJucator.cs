using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;
using ProiectExtra.Validator;

namespace ProiectExtra.Repository
{
    public class FileRepositoryJucator : FileRepository<string, Jucator>
    {
        public FileRepositoryJucator(IValidator<Jucator> validator, string numeFisier) : base(validator, numeFisier)
        {
        }
        public override Jucator extractEntity(String line)
        {
            string[] split = line.Split(";");
            Jucator entity = new Jucator(split[0], split[1], split[2], split[3]);
            return entity;
        }
    }
}
