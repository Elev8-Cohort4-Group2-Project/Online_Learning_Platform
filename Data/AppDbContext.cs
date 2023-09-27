using LMS_Clone.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LMS_Clone.Data {
    public class AppDbContext : IdentityDbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);


            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
       .SelectMany(t => t.GetForeignKeys())
       .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<CourseResource> CourseResources { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<StudentCourseAssignment> StudentCourseAssignments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }

        


    }
}
