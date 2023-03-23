using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FFriend.Infra
{
    public class FFDbFactory : IDesignTimeDbContextFactory<FFDbContext>
    {
        public FFDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FFDbContext>();
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=FFriendDb;Trusted_Connection=True;MultipleActiveResultSets=true"
                );
            return new FFDbContext(optionsBuilder.Options);
        }
    }
}