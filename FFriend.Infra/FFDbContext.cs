using FFriend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FFriend.Infra
{
    public class FFDbContext : DbContext
    {
        public FFDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Friend> Friend { get; set; }
        public DbSet<User> User { get; set; }
    }
}