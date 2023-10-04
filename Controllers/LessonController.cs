using LMS_Clone.Data;
using LMS_Clone.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Clone.Controllers {
    public class LessonController : Controller {
        private readonly AppDbContext _context;

        public LessonController(AppDbContext context) {
            _context = context;
        }


        public IActionResult Index() {
            return View();
        }

        public IActionResult Create(int courseId) {
            ViewBag.CourseId = courseId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Lesson lesson) {
            var res = _context.Lessons.Add(lesson);
            _context.SaveChanges();
            return RedirectToAction();
        }
    }
}
