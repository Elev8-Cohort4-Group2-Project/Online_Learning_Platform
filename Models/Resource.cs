using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Clone.Models {
    public class Resource {

        [Key] 
        public int ResourceId { get; set; }
        public string? Type { get; set; }
        public string? Content { get; set; }

        public int? LessonId { get; set; }
        public Lesson? Lesson { get; set; }
    }
}
