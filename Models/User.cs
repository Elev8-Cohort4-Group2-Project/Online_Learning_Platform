using LMS_Clone.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace LMS_Clone.Models {
    public class User:IdentityUser {
        [Required,DisplayName("First Name")]
        public string? FirstName { get; set; }
        [Required, DisplayName("Last Name")]
        public string? LastName { get; set; }
    }
}
