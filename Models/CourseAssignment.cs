using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Clone.Models {
    public class CourseAssignment : BaseEntity {
        public CourseAssignment() {
            isDeleted = false;
            isActive = true;
            creationTime = DateTime.Now;
        }

        [Key] // Primary Key
        public int CourseAssignmentID { get; set; }

        [MaxLength(100)] // Max Length 100 karakter
        public string Title { get; set; }

        [MaxLength(500)] // Max Length 500 karakter
        public string Description { get; set; }

        public int OverallScore { get; set; }

        [ForeignKey("Assignment")] // Foreign Key
        public int AssignmentID { get; set; }
        public virtual Assignment Assignment { get; set; }

        [ForeignKey("Course")] // Foreign Key
        public int? CourseID { get; set; }
        public virtual Course Course { get; set; }
    }
}
