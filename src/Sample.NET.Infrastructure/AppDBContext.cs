using Microsoft.EntityFrameworkCore;
using Sample.NET.Core;

namespace Sample.NET.Infrastructure
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<User> Users { get; set; } = null;
    }
}