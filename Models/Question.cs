using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Clone.Models {
    public class Question : BaseEntity {
        public Question() {
            isDeleted = false;
            isActive = true;
            creationTime = DateTime.Now;
        }

        [Key] // Primary Key
        public int QuestionID { get; set; }

        [MaxLength(500)] // Max Length 500 karakter
        public string QuestionText { get; set; }

        [MaxLength(100)] // Max Length 100 karakter
        public string Answer { get; set; }

        // Options için Max Length belirtilmemiştir, çünkü bu bir liste olarak saklanacaktır.
        //public List<string> Options { get; set; }

        [MaxLength(100)] // Max Length 100 karakter
        public string CorrectOption { get; set; }

        [ForeignKey("Lesson")] // Foreign Key
        public int LessonID { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
