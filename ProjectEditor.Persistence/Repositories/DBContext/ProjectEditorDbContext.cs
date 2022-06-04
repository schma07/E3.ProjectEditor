using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NPOI.SS.Formula.Functions;
using ProjectEditor.Core.Entities.Customers;
using ProjectEditor.Core.Entities.Devices;
using ProjectEditor.Core.Entities.Projects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Function = ProjectEditor.Core.Entities.Projects.Function; // due to nameconflict

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
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
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
                .HasForeignKey(l => l.LocationId)
                .HasForeignKey(f => f.FunctionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Project>()
                .HasOne(m => m.Customer)
                .WithMany(m => m.Projects)
                .HasForeignKey(m => m.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>()
                .HasMany(p => p.Projects)
                .WithOne(c => c.Customer)
                .HasForeignKey(g => g.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Location>()
                .HasOne(p => p.Project)
                .WithMany(l => l.Locations)
                .HasForeignKey(g => g.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Function>()
                .HasOne(p => p.Project)
                .WithMany(f => f.Functions)
                .HasForeignKey(g => g.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = new Guid("2A81C327-07A9-4B1D-A400-222B785F6481"), Name = "DummyCustomer Mani & Friends", CreatedBy = "Created via DbContext", Created = DateTime.Now },
                new Customer { Id = new Guid("02D2F7A4-8C6E-4F2E-873E-7EDC45314939"), Name = "DummyCustomer Hudli und Murks", CreatedBy = "Created via DbContext", Created = DateTime.Now },
                new Customer { Id = new Guid("651DD1B3-5ABE-4884-9BE8-59338C6165C8"), Name = "DummyCustomer Blue Monday", CreatedBy = "Created via DbContext", Created = DateTime.Now }
                );

            modelBuilder.Entity<Project>().HasData(
                new Project { Id = new Guid("ED9C66C8-E2EB-4764-B625-96657B603D25"), Name = "TimeControl 2.1", ProjectManagerName = "Nero", CustomerId = new Guid("2A81C327-07A9-4B1D-A400-222B785F6481"), CreatedBy = "Created via DbContext", Created = DateTime.Now },
                new Project { Id = new Guid("087B0654-C840-43A2-B827-90D47C5BA041"), Name = "WeatherChanger V1.0", ProjectManagerName = "Montgomery Burns", CustomerId = new Guid("02D2F7A4-8C6E-4F2E-873E-7EDC45314939"), CreatedBy = "Created via DbContext", Created = DateTime.Now },
                new Project { Id = new Guid("FE04D159-3CD6-4A19-A53E-48AB4425B5FD"), Name = "Water2Wine Vers.A", ProjectManagerName = "Queen Mary", CustomerId = new Guid("651DD1B3-5ABE-4884-9BE8-59338C6165C8"), CreatedBy = "Created via DbContext" }
                );

            modelBuilder.Entity<Location>().HasData(
                new Location { Id = new Guid("03e6c2e0-de3b-4dad-9f73-98b26e206f3d"), ProjectId = new Guid("ED9C66C8-E2EB-4764-B625-96657B603D25"), Description = "6 feet under", NameInSchematic = "+Dummy.LocA", CreatedBy = "Created via DbContext", Created = DateTime.Now },
                new Location { Id = new Guid("c6074116-b961-4232-acb4-2c663ff456c8"), ProjectId = new Guid("087B0654-C840-43A2-B827-90D47C5BA041"), Description = "up in sky", NameInSchematic = "+Dummy.LocB", CreatedBy = "Created via DbContext", Created = DateTime.Now },
                new Location { Id = new Guid("23d13a3a-245a-4178-8cce-09a9bd28781d"), ProjectId = new Guid("FE04D159-3CD6-4A19-A53E-48AB4425B5FD"), Description = "6 feet under", NameInSchematic = "+Dummy.LocC", CreatedBy = "Created via DbContext", Created = DateTime.Now }
                );

            modelBuilder.Entity<Function>().HasData(
                new Function { Id = new Guid("163de71d-3f88-4b0a-aed9-2d03d9d29bae"), ProjectId = new Guid("ED9C66C8-E2EB-4764-B625-96657B603D25"), Description = "hold my beer", NameInSchematic = "=Dummy.hmb", CreatedBy = "Created via DbContext", Created = DateTime.Now },
                new Function { Id = new Guid("fa4e431e-efe8-42f3-ba42-ea8c230567ae"), ProjectId = new Guid("087B0654-C840-43A2-B827-90D47C5BA041"), Description = "dancing on the table", NameInSchematic = "=Dummy.dOtT", CreatedBy = "Created via DbContext", Created = DateTime.Now },
                new Function { Id = new Guid("495ac5cd-6c39-401e-b206-ef9f349407a4"), ProjectId = new Guid("FE04D159-3CD6-4A19-A53E-48AB4425B5FD"), Description = "execute supernova", NameInSchematic = "=Dummy.SUPER", CreatedBy = "Created via DbContext", Created = DateTime.Now }
                );

            modelBuilder.Entity<Device>().HasData(
                new Device
                {
                    Id = new Guid("93752F09-7EB5-4D1C-8C25-B744A5C4DBBE"),
                    ProjectId = new Guid("ED9C66C8-E2EB-4764-B625-96657B603D25"),
                    LocationId = new Guid("03e6c2e0-de3b-4dad-9f73-98b26e206f3d"),
                    FunctionId = new Guid("fa4e431e-efe8-42f3-ba42-ea8c230567ae"),
                    Description = "DummyDevice A via DbContext",
                    NameInSchematic = "-K300",
                    CreatedBy = "Created via DbContext",
                    Created = DateTime.Now
                },

                new Device
                {
                    Id = new Guid("C5D683D9-F1F2-4C7A-9F3A-857AB00F2105"),
                    ProjectId = new Guid("087B0654-C840-43A2-B827-90D47C5BA041"),
                    LocationId = new Guid("c6074116-b961-4232-acb4-2c663ff456c8"),
                    FunctionId = new Guid("fa4e431e-efe8-42f3-ba42-ea8c230567ae"),
                    Description = "DummyDevice B via DbContext",
                    NameInSchematic = "-S200",
                    CreatedBy = "Created via DbContext",
                    Created = DateTime.Now
                },

                new Device
                {
                    Id = new Guid("D4D2CF99-99F1-4E29-B429-C03A6F1FF492"),
                    ProjectId = new Guid("FE04D159-3CD6-4A19-A53E-48AB4425B5FD"),
                    LocationId = new Guid("23d13a3a-245a-4178-8cce-09a9bd28781d"),
                    FunctionId = new Guid("495ac5cd-6c39-401e-b206-ef9f349407a4"),
                    Description = "DummyDevice C via DbContext",
                    NameInSchematic = "-K100",
                    CreatedBy = "Created via DbContext",
                    Created = DateTime.Now
                }
                );
        }
    }
}
