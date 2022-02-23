using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FbuSonMVC.Controllers
{
    public class LessonController : Controller
    {
        LessonManager lessonManager = new LessonManager(new InMemoryLessonDal());
        public IActionResult Index()
        {
            return View(lessonManager.GetLessons());
        }

        [HttpGet]
        public IActionResult AddLesson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLesson(Lesson lesson)
        {
           
            lessonManager.AddLesson(lesson);
            return RedirectToAction("Index");
        }
    }
}
