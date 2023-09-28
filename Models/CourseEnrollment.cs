using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Clone.Models {
    public class CourseEnrollment{


        [Key] 
        public int CourseEnrollmentId { get; set; }
        public string? Grade { get; set; }
        public int? CompletionStatus { get; set; }
        public string? Remark { get; set; }


        [ForeignKey("Student")]
        public string? StudentId { get; set; }
        public User? Student { get; set; }

        public int? CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
