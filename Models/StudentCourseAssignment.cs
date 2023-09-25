using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Clone.Models {
    public class StudentCourseAssignment : BaseEntity {
        public StudentCourseAssignment() {
            isDeleted = false;
            isActive = true;
            creationTime = DateTime.Now;
        }

        [Key] // Primary Key
        public int StudentCourseAssignmentID { get; set; }

        public int Score { get; set; }
        public DateTime DueDate { get; set; }

        [ForeignKey("Student")] // Foreign Key
        public string Id { get; set; }
        public virtual User Student { get; set; }

        [ForeignKey("CourseAssignment")] // Foreign Key
        public int AssignmentID { get; set; }
        public virtual CourseAssignment CourseAssignment { get; set; }
    }
}
