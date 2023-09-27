using LMS_Clone.Data;
using LMS_Clone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace LMS_Clone.Controllers {

    public class CourseController : Controller {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;

        public CourseController(AppDbContext context, UserManager<User> userManager) {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index() {
            // Retrieve all courses from the database
            var courses = await _context.Courses.ToListAsync();

            return View(courses);
        }
        
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Course course) {
            course.InstructorId = (await _userManager.GetUserAsync(User)).Id;
            _context.Courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

      





        public  IActionResult Delete(int id) {
            Course course = _context.Courses.Find(id);
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        /*
        public IActionResult Enroll(int id) {
            var course = _context.Courses.Find(id);
            CourseEnrollment enrollment = new CourseEnrollment();
            enrollment.CourseID = id;
            enrollment.StudentID = User.Identity.GetUserId();
            _context.CourseEnrollments.Add(enrollment);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        */
       
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.CourseID == id);

            if (course == null) {
                return NotFound();
            }


            //int userID;  //int.TryParse(u.Id, out userId) && userId == course.InstructorID
            // Fetch the instructor's name from the Users table based on the InstructorID
            var instructorName = await _context.Users
                .Where(u => u.Id == course.InstructorId)
                .Select(u => u.UserName)
                .FirstOrDefaultAsync();

            

            // Pass both the course and instructor name to the view
            ViewData["InstructorName"] = instructorName ?? "N/A";
            return View(course);
        }

        
    }



}
