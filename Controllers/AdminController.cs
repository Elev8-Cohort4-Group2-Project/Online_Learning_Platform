using LMS_Clone.Data;
using LMS_Clone.Models;
using LMS_Clone.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Clone.Controllers {
    public class AdminController : Controller {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context) {
            _context = context;

        }
        public IActionResult Index() {
            IList<Course> allCourse = _context.Courses.ToList();
            IList<User> allUser = _context.Users.ToList();

            UserCourse userCourse = new UserCourse {
                Course = allCourse,
                User = allUser
            };
            return View(userCourse);
            
        }

        
        
    }
}
