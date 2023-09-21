using System.ComponentModel.DataAnnotations;

namespace Online_Learning_Platform.Models {
    public class Course {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int InstructorID { get; set; }
        public string Category { get; set }
        public int EnrollmentCount { get; set}
        public string ImageURL { get; set; }
    }
}
