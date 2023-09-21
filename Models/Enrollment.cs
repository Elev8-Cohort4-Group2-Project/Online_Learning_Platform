using System.ComponentModel.DataAnnotations;

namespace Online_Learning_Platform.Models {
    public class Enrollment {
        [Key]
        public int EnrollmentID { get; set; }
        public int UserID { get;set; }
        public int CourseID { get; set; }
        public string EnrollmentDate { get; set; }
    }
}
