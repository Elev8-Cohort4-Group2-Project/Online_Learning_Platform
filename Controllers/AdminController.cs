using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_Clone.Models; // Adjust the namespace accordingly

[Authorize(Roles = "Admin")] // Restrict access to admin role only
public class AdminController : Controller
{
    private readonly ApplicationDbContext _context; // Replace with your DbContext

    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: /Admin/Dashboard
    public async Task<IActionResult> Dashboard()
    {
        // Retrieve a list of students and the courses they are enrolled in

        var studentsWithCourses = await _context.Users
            .Include(u => u.Courses) // Assuming you have a navigation property called "Courses" in your ApplicationUser class
            .Where(u => u.Roles.Any(r => r.Role.Name == "Student"))
            .Select(user => new DashboardViewModel
            {
                Student = user,
                EnrolledCourses = user.Courses.ToList()
            })
            .ToListAsync();

        return View(studentsWithCourses);
    }

    // GET: /Admin/CreateCourse
    public IActionResult CreateCourse()
    {
        // Add logic to create a new course (form or other input methods)
        return View();
    }

    // POST: /Admin/CreateCourse
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateCourse(Course course)
    {
        // Add logic to save the new course to the database
        if (ModelState.IsValid)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Dashboard));
        }
        return View(course);
    }

    // GET: /Admin/ManageUsers
    public async Task<IActionResult> ManageUsers()
    {
        // Retrieve a list of all users (students and admins)
        var allUsers = await _userManager.Users.ToListAsync();

        return View(allUsers);
    }

    public class DashboardViewModel
    {
        public ApplicationUser Student { get; set; }
        public List<Course> EnrolledCourses { get; set; }
    }
}
