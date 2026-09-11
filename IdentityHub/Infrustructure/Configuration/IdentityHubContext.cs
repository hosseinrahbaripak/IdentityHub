using Microsoft.EntityFrameworkCore;
using Domain;
namespace Infrustructure.Configuration
{
    public class IdentityHubContext : DbContext
    {
        public IdentityHubContext(DbContextOptions<IdentityHubContext> options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }

    }
}
