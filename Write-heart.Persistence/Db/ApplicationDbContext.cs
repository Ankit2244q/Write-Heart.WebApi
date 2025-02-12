using Microsoft.EntityFrameworkCore;
using Write_Heart.Domain.Entities;

namespace Write_heart.Persistence.Db
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserPosts> UsersPost { get; set; }
    }
}
