using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Data;

namespace Online_Learning_Platform.Controllers {
    public class UserController : Controller {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context) {
            _context = context;
        }

        public IActionResult Index() {
            var allUser = _context.Users.ToList();
            return View();
        }
    }
}
