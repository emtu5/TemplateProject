using Microsoft.EntityFrameworkCore;
using net_project.Models;

namespace net_project.Data
{
    public class TemplateContext : DbContext
    {
        /*public DbSet<User> Users { get; set; }*/
        public DbSet<Profesor> Profesori { get; set; }
        public DbSet<Materie> Materii { get; set; }
        public DbSet<RelatieProfesorMaterie> Relatii { get; set; }
        public TemplateContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<RelatieProfesorMaterie>().HasKey(x => new { x.ProfesorId, x.MaterieId });

            modelBuilder.Entity<RelatieProfesorMaterie>()
                        .HasOne(x => x.Profesor)
                        .WithMany(x => x.Relatii)
                        .HasForeignKey(x => x.ProfesorId);

            /* cum sa pierzi juma de ora: lasi .HasOne(x => x.Profesori) jos*/
            modelBuilder.Entity<RelatieProfesorMaterie>()
                        .HasOne(x => x.Materie)
                        .WithMany(x => x.Relatii)
                        .HasForeignKey(x => x.MaterieId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
