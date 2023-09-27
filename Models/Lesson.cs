using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Clone.Models {
    public class Lesson : BaseEntity {
        public Lesson() {
            isDeleted = false;
            isActive = true;
            creationTime = DateTime.Now;
        }

        [Key] // Primary Key
        public int LessonID { get; set; }

        public ICollection<Resource> Resources { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
