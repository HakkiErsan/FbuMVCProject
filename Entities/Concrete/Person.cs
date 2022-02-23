using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person : IEntity
    {
        private static int Count = 0;

        public Person()
        {
            PersonId = Count;
            Count++;
        }

        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
    }
}
