using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryPersonDal : IPersonDal
    {
        private static List<Person> _people;

        public InMemoryPersonDal()
        {
            if (_people == null)
            {
                Init(new Person() { PersonName="Hakkı",PersonSurname="Ersan"});
            }
        }

        public void Add(Person entity)
        {
            _people.Add(entity);
        }

        public void Delete(Person entity)
        {
            Person deletePerson = _people.SingleOrDefault(p=>p.PersonId==entity.PersonId);
            if (deletePerson != null)
            {
                _people.Remove(deletePerson);
            }
        }

        public List<Person> GetAll()
        {
            return _people;
        }

        public void Init(Person entity)
        {
            _people = new List<Person>();
            _people.Add(entity);
        }

        public void Update(Person entity)
        {
            Person updatePerson = _people.SingleOrDefault(p=>p.PersonId == entity.PersonId);

            updatePerson.PersonName = entity.PersonName;
            updatePerson.PersonSurname = entity.PersonSurname;
   
        }
    }
}
