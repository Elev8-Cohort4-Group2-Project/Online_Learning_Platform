using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Data;

namespace Online_Learning_Platform.Controllers {
    public class AssignmentController : Controller {
        private readonly AppDbContext _context;

        public AssignmentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() {
            var allAssignment = _context.Assignments.ToList();
            return View();
        }
    }
}
