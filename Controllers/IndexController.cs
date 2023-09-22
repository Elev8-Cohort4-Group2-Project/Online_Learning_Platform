using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    // GET: /Home/Index
    public IActionResult Index()
    {
        // You can add logic here to retrieve data for featured courses
        // from your database and pass it to the view
        var featuredCourses = GetFeaturedCoursesFromDatabase();

        // You can also add logic for the "How It Works" section
        // and any other necessary data

        // Pass data to the view
        ViewData["FeaturedCourses"] = featuredCourses;

        return View();
    }

    // You can define other actions and methods for your homepage here

    private List<Course> GetFeaturedCoursesFromDatabase()
    {
        // Implement code here to fetch featured courses from your database
        // Example: You may use Entity Framework to interact with your database
        // Replace this with your actual data retrieval logic
        var featuredCourses = new List<Course>
        {
            new Course { Id = 1, Title = "Introduction to Programming", Description = "Learn the basics of programming."},
            new Course { Id = 2, Title = "Web Development Fundamentals", Description = "Get started with web development."},
            new Course { Id = 3, Title = "Data Science Essentials", Description = "Explore data science concepts."}
        };

        return featuredCourses;
    }
}
