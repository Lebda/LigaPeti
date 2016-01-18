using LigaPetiDbModel.Entities.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LigaPetiDbModel.DataContext.Identity
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            : base("LigaPetiWeb", throwIfV1Schema: false)
        {
        }

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }
    }
}