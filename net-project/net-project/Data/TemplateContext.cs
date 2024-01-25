using Microsoft.EntityFrameworkCore;
using net_project.Models;

namespace net_project.Data
{
    public class TemplateContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public TemplateContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
