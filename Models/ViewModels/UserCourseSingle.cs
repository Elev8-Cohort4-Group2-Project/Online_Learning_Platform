using Microsoft.AspNetCore.Identity;

namespace LMS_Clone.Models.ViewModels {
    public class UserCourseSingle {
        public Course? Course { get; set; }
        public User? User { get; set; }
        public UserManager<User>? UserManager { get; set; }
    }
}
