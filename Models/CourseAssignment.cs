using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMS_Clone.Models {
    public class CourseAssignment {

        [Key] 
        public int CourseAssignmentId { get; set; }
        public int? OverallScore { get; set; }

        public int? AssignmentId { get; set; }
        public Assignment? Assignment { get; set; }

        public int? CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
