using LMS_Clone.Data;
using LMS_Clone.Models;
using LMS_Clone.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Clone.Controllers {
    public class AdminController : Controller {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;

        public AdminController(AppDbContext context, UserManager<User> userManager) {
            _context = context;
            _userManager = userManager;

        }
        public IActionResult Index() {
            IList<Course> allCourse = _context.Courses.ToList();
            IList<User> allUser = _context.Users.ToList();

            UserCourse userCourse = new UserCourse {
                Course = allCourse,
                User = allUser,
                UserManager = _userManager
            };
            return View(userCourse);
            
        }

        
        
    }
}
