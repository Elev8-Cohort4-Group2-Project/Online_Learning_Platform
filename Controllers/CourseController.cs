using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Data;

namespace Online_Learning_Platform.Controllers {
    public class CourseController : Controller {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() {
            var allCourse = _context.Courses.ToList();
            return View();
        }
    }
}
