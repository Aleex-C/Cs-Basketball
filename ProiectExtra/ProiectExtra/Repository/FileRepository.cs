using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;
using ProiectExtra.Validator;

namespace ProiectExtra.Repository
{
    public abstract class FileRepository<ID, E> : InMemoryRepository<ID, E> where E : Entitate<ID>
    {
        protected string NumeFisier;

        public FileRepository(IValidator<E> validator, string numeFisier) :
            base(validator)
        {
            NumeFisier = numeFisier;
                LoadFromFile();
        }
        public abstract E extractEntity(String line);
        void LoadFromFile()
        {
            using (var fileStream = File.OpenRead(this.NumeFisier))
            using (var streamReader = new StreamReader(fileStream))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    E entitate = this.extractEntity(line);
                    base.Save(entitate);
                }
            }
        }
    }
}
