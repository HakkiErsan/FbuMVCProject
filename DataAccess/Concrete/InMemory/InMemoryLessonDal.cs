using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryLessonDal : ILessonDal
    {
        private static List<Lesson> _lessons;

        public InMemoryLessonDal()
        {
            if(_lessons == null)
            {
                Init(new Lesson() { LessonName="C# 101",LessonCredit=5});
            }
        }
        public void Add(Lesson entity)
        {
            _lessons.Add(entity);
        }

        public void Delete(Lesson entity)
        {
            Lesson deleteLesson = _lessons.SingleOrDefault(l=>l.LessonId==entity.LessonId);
            if(deleteLesson != null)
            {
                _lessons.Remove(deleteLesson);
            }
        }

        public List<Lesson> GetAll()
        {
            return _lessons;
        }

        public void Init(Lesson entity)
        {
            _lessons = new List<Lesson>();
            _lessons.Add(entity);
        }

        public void Update(Lesson entity)
        {
            Lesson updatedLesson = _lessons.FirstOrDefault(l=>l.LessonId == entity.LessonId);
            updatedLesson.LessonName = entity.LessonName;
            updatedLesson.LessonCredit = entity.LessonCredit;
        }
    }
}
