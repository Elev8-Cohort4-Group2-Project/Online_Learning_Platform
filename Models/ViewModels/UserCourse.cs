﻿using Microsoft.AspNetCore.Identity;

namespace LMS_Clone.Models.ViewModels {
    public class UserCourse {
        public IList<Course> Course { get; set; }
        public IList<User> User { get; set; }
        public UserManager<User>? UserManager { get; set; }
    }

}
