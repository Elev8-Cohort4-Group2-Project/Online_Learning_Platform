using LMS_Clone.Data;
using LMS_Clone.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LMS_Clone.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context) {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() {
            List<Course> allCourses = _context.Courses.ToList();
            return View(allCourses);
        }

        public IActionResult Details(Course course) {
            return View(course);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}