using LMS_Clone.Data;
using LMS_Clone.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Clone.Controllers {
    public class UserController : Controller {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context) {
            _context = context;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Create() {
            return View();
        }

        public IActionResult Edit() {
            return View();
        }

        public IActionResult Delete() {
            return View();
        }
    
        public IActionResult Profile(string id) {
            return View(_context.Users.Find(id));
        }













    }
}
