using Microsoft.AspNet.Identity.EntityFramework;

namespace SignalR_app.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("Database1") { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}