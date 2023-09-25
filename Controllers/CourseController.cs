using LMS_Clone.Data;
using LMS_Clone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS_Clone.Controllers {

    public class CoursesController : Controller {
        private readonly AppDbContext _context;

        public CoursesController(AppDbContext context) {
            _context = context;
        }

        public async Task<IActionResult> Index() {
            // Retrieve all courses from the database
            var courses = await _context.Courses.ToListAsync();

            return View("~/Views/Home/Index.cshtml", courses);
        }

        /*

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
                .Where(u => u.Id == course.InstructorID)
                .Select(u => u.UserName)
                .FirstOrDefaultAsync();

            

            // Pass both the course and instructor name to the view
            ViewData["InstructorName"] = instructorName ?? "N/A";
            return View(course);
        }

        */
    }



}
