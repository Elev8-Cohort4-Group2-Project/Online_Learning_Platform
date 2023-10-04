using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using LMS_Clone.Data;

namespace LMS_Clone.Models {
    public class Question {


        [Key]
        public int QuestionId { get; set; }
        public string? QuestionText { get; set; }
        public string? Option1 { get; set; }
        public string? Option2 { get; set; }
        public string? Option3 { get; set; }
        public string? Option4 { get; set; }
        public int? CorrectOption { get; set; }

        public int? AssignmentId { get; set; }
        public Assignment? Assignment { get; set; }
    }
}
