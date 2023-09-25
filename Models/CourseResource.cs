using Elfie.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Clone.Models {
    public class CourseResource : BaseEntity {
        public CourseResource() {
            isDeleted = false;
            isActive = true;
            creationTime = DateTime.Now;
        }

        [Key] // Primary Key
        public int CourseResourceID { get; set; }

        [MaxLength(50)] // Max Length 50 karakter
        public string ResourceType { get; set; }

        [MaxLength(1000)] // Max Length 1000 karakter
        public string Content { get; set; }



        [ForeignKey("Course")] // Foreign Key
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }

        [ForeignKey("Resource")] // Foreign Key
        public int ResourceID { get; set; }
        public virtual Resource Resource { get; set; }
    }
}
