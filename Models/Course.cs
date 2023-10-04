 using LMS_Clone.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Clone.Models {
    public class Course  {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Category { get; set; }
        public byte[]? Image { get; set; }
        public int EnrollmentCount { get;set; }

        [ForeignKey("Instructor")] 
        public string? InstructorId { get; set; }
        public User? Instructor { get; set; }
        

        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<CourseAssignment>? CourseAssignments { get; set; }
        public ICollection<CourseEnrollment>? CourseEnrollments { get; set; }


        public Course() {
            EnrollmentCount = 0;
        }
    }
}
