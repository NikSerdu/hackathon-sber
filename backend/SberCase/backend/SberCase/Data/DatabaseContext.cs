using Microsoft.EntityFrameworkCore;
using SberCase.Models;

namespace SberCase.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();

            modelBuilder.Entity<Obligation>()
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();

            modelBuilder.Entity<Report>()
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();

            modelBuilder.Entity<Profile>()
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();

            modelBuilder.Entity<Underwriter>()
                        .Property(e => e.Id)
                        .ValueGeneratedOnAdd();

            modelBuilder.Entity<Report>().Navigation(e => e.Obligations).AutoInclude();
            //modelBuilder.Entity<Report>().Navigation(e => e.Application).AutoInclude();
            //modelBuilder.Entity<Application>().Navigation(e => e.Profile).AutoInclude();
            //modelBuilder.Entity<Profile>().Navigation(e => e.Application).AutoInclude();
            //modelBuilder.Entity<Obligation>().Navigation(e => e.Report).AutoInclude();

            /*
            modelBuilder.Entity<Application>().HasData(
                new Application { }
            );
            modelBuilder.Entity<Obligation>().HasData(
                new Obligation { }
            );
            modelBuilder.Entity<Profile>().HasData(
                new Profile { }
            );
            modelBuilder.Entity<Report>().HasData(
                new Report { }
            );
            */
            //modelBuilder.Entity<Underwriter>().HasData(new Underwriter { });
        }

        public virtual DbSet<Application> Applications { get; set; } = default!;
        public virtual DbSet<Obligation> Obligations { get; set; } = default!;
        public virtual DbSet<Profile> Profiles { get; set; } = default!;
        public virtual DbSet<Report> Reports { get; set; } = default!;
        public virtual DbSet<Underwriter> Underwriters { get; set; } = default!;
    }
}
