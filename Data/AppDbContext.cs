using LMS_Clone.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LMS_Clone.Data {
    public class AppDbContext : IdentityDbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<CourseResource> CourseResources { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<StudentCourseAssignment> StudentCourseAssignments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            /*modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, FirstName = "Serhat", LastName = "Basesgioglu", Email = "serhat@gmail.com", Password = "1234", Role = Role.Admin },
                new User { UserID = 2, FirstName = "Deniz", LastName= "Cirpan", Email= "deniz@gmail.com", Password= "123", Role=Role.Instructor},
                new User { UserID = 3, FirstName = "Emir", LastName = "Erdogdu", Email = "emir@gmail.com", Password = "124",Role =Role.Instructor},
                new User { UserID = 4, FirstName = "Bugra", LastName = "Ilhan", Email = "bugra@gmail.com", Password = "1256", Role = Role.Instructor},
                new User { UserID = 5, FirstName = "Melih", LastName = "Yilmaz", Email = "melih@gmail.com", Password = "235", Role = Role.Student}
                );
            
            modelBuilder.Entity<Course>().HasData(
                new Course {CourseID = 1, Title = "Introduction to Calculus", Description = "Entry Level Calculus Course", Category = Category.Mathematics, ImageUrl = "https://media.istockphoto.com/id/1265965042/tr/vekt%C3%B6r/matematik-teorisi-s%C4%B1n%C4%B1f-tebe%C5%9Fir-tahtas%C4%B1nda-matematik-hesab%C4%B1-cebir-ve-geometri-bilimi-el.jpg?s=1024x1024&w=is&k=20&c=aHp7kkRESOKqyVkp30-0l14mnLWA8z9fYKniKf6HT60="}
                );
            */
        }


    }
}
