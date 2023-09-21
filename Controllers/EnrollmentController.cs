using Microsoft.AspNetCore.Mvc;
using Online_Learning_Platform.Data;

namespace Online_Learning_Platform.Controllers {
    public class EnrollmentController : Controller {
        private readonly AppDbContext _context;

        public EnrollmentController(AppDbContext context)
        {
            _context = context;
        }       
        public IActionResult Index() {
            var allEnrollments = _context.Enrollments.ToList();
            return View();
        }
    }
}
