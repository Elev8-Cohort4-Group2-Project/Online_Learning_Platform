using LMS_Clone.Data;
using LMS_Clone.Models;
using LMS_Clone.Models.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS_Clone.Controllers {
    public class CourseController : Controller {
        private readonly AppDbContext? _context;

        public CourseController(AppDbContext context) {
            _context = context;
        }


        public IActionResult Index() {
            
            return View(_context.Courses.ToList());
        }


        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course, IFormFile file) {
            course.InstructorId = User.Identity.GetUserId();

            if (file != null && file.Length > 0) {
                using (var stream = new MemoryStream()) {
                    file.CopyTo(stream);
                    course.Image = stream.ToArray();
                }
            }

            _context.Courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id) {
            Course course = _context.Courses.Find(id);
            return View(course);
        }

        [HttpPost]
        public IActionResult Edit(Course course) {
            _context.Courses.Update(course);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

       public IActionResult Delete(int id) {
            Course course = _context.Courses.Find(id);
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id) {
            var lessons = _context.Courses
                    .Include(o => o.Lessons)
                    .Where(o => o.CourseId == id)
                    .SelectMany(o => o.Lessons)
                    .ToList();
            var course = _context.Courses.Find(id);

            ViewBag.Lessons = lessons;
            return View(course);
        }

        public IActionResult Enroll(int id) {
            CourseEnrollment enrollment = new CourseEnrollment();
            enrollment.CourseId = id;
            enrollment.StudentId = User.Identity.GetUserId();
            _context.CourseEnrollments.Add(enrollment);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }























    }
}
