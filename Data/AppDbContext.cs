using LMS_Clone.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LMS_Clone.Data {
    public class AppDbContext : IdentityDbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);


            

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }

        


    }
}
