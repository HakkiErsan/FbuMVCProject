using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Lesson : IEntity
    {
        private static int Count = 0;
        public Lesson()
        {
            LessonId = Count;
            Count++;
        }
        public int LessonId { get; set; }
        public string LessonName { get; set; }

        public int LessonCredit { get; set; }
    }
}
