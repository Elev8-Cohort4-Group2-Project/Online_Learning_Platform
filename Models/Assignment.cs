using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Clone.Models {
    public class Assignment {
        [Key]
        public int AssignmentId { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Required]
        public DateTime? DueDate { get; set; }

        public ICollection<Question>? Questions { get; set; }
        public ICollection<CourseAssignment>? CourseAssignments { get; set; }
    }
}