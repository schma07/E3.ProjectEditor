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
                .HasMany(g => g.Projects) 
                .WithOne(g => g.Customer) 
                .HasForeignKey(g => g.CustomerId) 
                .OnDelete(DeleteBehavior.Restrict); 





            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = new Guid ("2A81C327-07A9-4B1D-A400-222B785F6481"), Name = "DummyCustomer Mani & Friends" },
                new Customer { Id = new Guid("02D2F7A4-8C6E-4F2E-873E-7EDC45314939"), Name = "DummyCustomer Hudli und Murks" },
                new Customer { Id = new Guid("651DD1B3-5ABE-4884-9BE8-59338C6165C8"), Name = "DummyCustomer Blue Monday" }                
                );

            modelBuilder.Entity<Project>().HasData(
                new Project { Id = new Guid("ED9C66C8-E2EB-4764-B625-96657B603D25"), CustomerId = new Guid("2A81C327-07A9-4B1D-A400-222B785F6481") },
                new Project { Id = new Guid("087B0654-C840-43A2-B827-90D47C5BA041"), CustomerId = new Guid("02D2F7A4-8C6E-4F2E-873E-7EDC45314939") },
                new Project { Id = new Guid("FE04D159-3CD6-4A19-A53E-48AB4425B5FD"), CustomerId = new Guid("651DD1B3-5ABE-4884-9BE8-59338C6165C8") }                
                );

            modelBuilder.Entity<Device>().HasData(
                new Device { Id = new Guid("93752F09-7EB5-4D1C-8C25-B744A5C4DBBE"), ProjectId = new Guid("ED9C66C8-E2EB-4764-B625-96657B603D25"), Name = "DummyDevice -K300" },
                new Device { Id = new Guid("C5D683D9-F1F2-4C7A-9F3A-857AB00F2105"), ProjectId = new Guid("087B0654-C840-43A2-B827-90D47C5BA041"), Name = "DummyDevice -S200" },
                new Device { Id = new Guid("D4D2CF99-99F1-4E29-B429-C03A6F1FF492"), ProjectId = new Guid("FE04D159-3CD6-4A19-A53E-48AB4425B5FD"), Name = "DummyDevice -S450" }
                );

        }
    }
}
