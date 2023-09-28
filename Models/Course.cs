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

        [ForeignKey("Instructor")] // Foreign Key
        public string? InstructorId { get; set; }
        public User? Instructor { get; set; }
        

        public ICollection<Resource>? Resources { get; set; }
        public ICollection<CourseAssignment>? CourseAssignments { get; set; }
        public ICollection<CourseEnrollment>? CourseEnrollments { get; set; }
    }
}
