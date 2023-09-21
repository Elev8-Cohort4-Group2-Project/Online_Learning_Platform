using System.ComponentModel.DataAnnotations;

namespace Online_Learning_Platform.Models {
    public class Assignment {
        [Key]
        public int AssignemntID { get; set; }
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
    }
}
