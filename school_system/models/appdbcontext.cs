using Microsoft.EntityFrameworkCore;

namespace school_system.models
{
    public class appdbcontext : DbContext
    {
        public appdbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<students> students { get; set; }
        public DbSet<subjects> subjects { get; set; }
    }
}
