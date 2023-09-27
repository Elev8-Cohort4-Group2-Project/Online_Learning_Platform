 using LMS_Clone.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Clone.Models {
    public class Course : BaseEntity {
        public Course() {
            isDeleted = false;
            isActive = true;
            creationTime = DateTime.Now;
        }

        [Key]
        public int CourseID { get; set; }

        [MaxLength(100)] // Max Length 100 karakter
        public string Title { get; set; }

        [MaxLength(500)] // Max Length 500 karakter
        public string Description { get; set; }

        [MaxLength(50)] // Max Length 50 karakter
        public string Category { get; set; }

        [MaxLength(200)] // Max Length 200 karakter
        public string ImageURL { get; set; }

        public int OverallScore { get; set; }

        [ForeignKey("Instructor")] // Foreign Key
        public string InstructorId { get; set; }
        public virtual User Instructor { get; set; }
        

        public ICollection<CourseResource> CourseResources { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public ICollection<CourseEnrollment> CourseEnrollments { get; set; }
    }
}
