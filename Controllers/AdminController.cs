using LMS_Clone.Data;
using LMS_Clone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Dynamic;

namespace LMS_Clone.Controllers {
    [Authorize(Roles = "Admin")] // Restrict access to admin role only
    public class AdminController : Controller {
        private readonly AppDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public AdminController(AppDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager) {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index() {


            var studentsWithCourses = await _context.Users.ToListAsync();
            return View(studentsWithCourses);
        }

        // GET: /Admin/CreateCourse
        public IActionResult CreateCourse() {
            // Add logic to create a new course (form or other input methods)
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCourse(Course course) {
            if (ModelState.IsValid) {
                _context.Courses.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }


        public async Task<IActionResult> ManageUser() {
            var allUsers = await _userManager.Users.ToListAsync();
            var userManager = _userManager;
            dynamic model = new ExpandoObject();
            model.Users = allUsers;
            model.UserManager = userManager;
            return View(model);
        }

        public async Task<IActionResult> DeleteUser(string id) {
            User user = await _userManager.FindByIdAsync(id);
            _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(ManageUser));
        }

        public IActionResult Profile() {
            return View();
        }

    }
}
