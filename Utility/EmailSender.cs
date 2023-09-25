using Microsoft.AspNetCore.Identity.UI.Services;

//Placeholder function, does not do anything

namespace LMS_Clone.Utility {
    public class EmailSender : IEmailSender {
        public Task SendEmailAsync(string email, string subject, string htmlMessage) {
            return Task.CompletedTask;
        }
    }
} 
