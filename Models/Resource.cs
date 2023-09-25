using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Clone.Models {
    public class Resource : BaseEntity {
        public Resource() {
            isDeleted = false;
            isActive = true;
            creationTime = DateTime.Now;
        }

        [Key] // Primary Key
        public int ResourceID { get; set; }

        [MaxLength(50)] // Max Length 50 karakter
        public string Type { get; set; }

        [MaxLength(1000)] // Max Length 1000 karakter
        public string Content { get; set; }

        [ForeignKey("Lesson")] // Foreign Key
        public int LessonID { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
