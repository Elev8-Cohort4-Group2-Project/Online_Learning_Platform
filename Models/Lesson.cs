using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Clone.Models {
    public class Lesson {
        [Key]
        public int LessonId { get; set; }
        public int? Number { get; set; }
        public string? Name { get; set; }

        public int? CourseId { get; set; }
        public Course? Course { get; set; }

        public ICollection<Resource>? Resources { get; set; }
        public ICollection<Assignment>? Assignments { get; set; }
    }
}
