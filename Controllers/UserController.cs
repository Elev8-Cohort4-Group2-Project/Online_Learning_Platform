using LMS_Clone.Data;
using LMS_Clone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Clone.Controllers {
    public class UserController : Controller {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(AppDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager) {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index() {
            return View();
        }


        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user, string role, string password) {
            user.UserName = user.Email;
            var result = await _userManager.CreateAsync(user,password);
            if (role == "Admin")             { await _userManager.AddToRoleAsync(user, StaticData.Role_Admin); }
            else if (role == "Instructor")   { await _userManager.AddToRoleAsync(user, StaticData.Role_Instructor); }
            else                             { await _userManager.AddToRoleAsync(user, StaticData.Role_Student); }
            return RedirectToAction("Index", "Admin");
        }

        public IActionResult Edit() {
            return View();
        }

        public async Task<IActionResult> Delete(string id) {
            var user = await _userManager.FindByIdAsync(id);
            await _userManager.DeleteAsync(user);
            return RedirectToAction("Index", "Admin");
        }
    
        public IActionResult Profile(string id) {
            return View(_context.Users.Find(id));
        }













    }
}
