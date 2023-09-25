using LMS_Clone.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace LMS_Clone.Models {
    public class User:IdentityUser {
        public int UserID { get; set; }
        [Required,DisplayName("First Name")]
        public string? FirstName { get; set; }
        [Required, DisplayName("Last Name")]
        public string? LastName { get; set; }
        [Required]
        public Role Role { get; set; }
    }
}
