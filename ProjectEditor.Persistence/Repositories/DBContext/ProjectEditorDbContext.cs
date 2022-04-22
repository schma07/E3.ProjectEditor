using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectEditor.Core.Entities.Customers;
using ProjectEditor.Core.Entities.Devices;
using ProjectEditor.Core.Entities.Projects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectEditor.Persistence.Repositories.DBContext
{
    public class ProjectEditorDbContext : DbContext
    {
        public ProjectEditorDbContext()
        {
        }

        public ProjectEditorDbContext(DbContextOptions<ProjectEditorDbContext> options) : base(options)
        {
            Database.SetCommandTimeout(60); //-> default Wert für Timeout ist 90s
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Device> Devices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var currentDirectory = Directory.GetCurrentDirectory();

#if DEBUG

            if (currentDirectory.IndexOf("bin") > -1)
            {
                currentDirectory = currentDirectory.Substring(0, currentDirectory.IndexOf("bin"));
            }

            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = configurationBuilder.Build();

            //var connectionString = configuration.GetConnectionString("MovieDbContextLocal");
            var connectionString = configuration.GetConnectionString(nameof(ProjectEditorDbContext) + "Local");
            var commandTimeout = 60;
            optionsBuilder.UseSqlServer(connectionString, opts => opts.CommandTimeout(commandTimeout));
#endif
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Constraints 
            modelBuilder.Entity<Device>()
                .HasOne(m => m.Project)
                .WithMany(m => m.Devices)
                .HasForeignKey(m => m.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Project>()
                .HasOne(m => m.Customer)
                .WithMany(m => m.Projects)
                .HasForeignKey(m => m.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Customer>()
                .HasMany(g => g.Devices) // Ein Genre kann in beliebig vielen Movie Datensätzen verwendet werden.
                .WithOne(g => g.Name) // Jedes Genre existiert nur einmal für ein Movie kann nur ein Genre definiert werden.
                .HasForeignKey(g => g.CustomerId) // Fremdschlüsselfeld PK <=> FK 
                .OnDelete(DeleteBehavior.Restrict); // -> Stellt sicher dass kein Film gelöscht wird, wenn ein Genre gelöscht wird. (Löschweitergabe unterbinden)





            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = new Guid (""), Name = "DummyCustomer Mani & Friends" },
                new Customer { Id = new Guid(""), Name = "DummyCustomer Hudli und Murks" },
                new Customer { Id = new Guid(""), Name = "DummyCustomer Blue Monday" }                
                );

            modelBuilder.Entity<Project>().HasData(
                new Project { Id = new Guid(""), Name = "Digital Versatile Disc" },
                new Project { Id = new Guid(""), Name = "Blue Ray" },
                new Project { Id = new Guid(""), Name = "Blue Ray High Definition Res." }                
                );

            modelBuilder.Entity<Device>().HasData(
                new Device { Id = new Guid("93752F09-7EB5-4D1C-8C25-B744A5C4DBBE"), GenreId = 4, Name = "Star Trek Discovery Season 1", Price = 34.90m, MediumTypeCode = "BR", ReleaseDate = new DateTime(2017, 9, 14), Rating = Ratings.Great },
                new Device { Id = new Guid("C5D683D9-F1F2-4C7A-9F3A-857AB00F2105"), GenreId = 1, Name = "Stirb langsam", Price = 7.90m, MediumTypeCode = "DVD", ReleaseDate = new DateTime(1998, 11, 1), Rating = Ratings.Unrated },
                new Device { Id = new Guid("D4D2CF99-99F1-4E29-B429-C03A6F1FF492"), GenreId = 3, Name = "Titanic", Price = 9.90m, MediumTypeCode = "BR-3D", ReleaseDate = new DateTime(1994, 10, 14), Rating = Ratings.Medium }
                );

        }
    }
}
