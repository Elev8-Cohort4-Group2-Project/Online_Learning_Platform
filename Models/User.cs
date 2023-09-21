﻿using System.ComponentModel.DataAnnotations;

namespace Online_Learning_Platform.Models {
    public class User {
        [Key]
        public int UserID{ get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}