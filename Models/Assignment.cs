﻿using System.ComponentModel.DataAnnotations;

namespace Online_Learning_Platform.Models {
    public class Assignment {
        [Key]
        public int AssignmentID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public int? CourseID { get; set; }
        public Course Course { get; set; }
    }
}