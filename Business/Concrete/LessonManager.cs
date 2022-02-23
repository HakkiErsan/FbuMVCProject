using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LessonManager : ILessonServices
    {
        private readonly ILessonDal _lessonDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }

        public void AddLesson(Lesson lesson)
        {
            if (!(lesson.LessonCredit <= 0 || String.IsNullOrEmpty(lesson.LessonName)))
            {
                _lessonDal.Add(lesson);
            }
         
        }

        public List<Lesson> GetLessons()
        {
            return _lessonDal.GetAll();
        }
    }
}
