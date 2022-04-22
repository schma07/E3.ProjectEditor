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

    }
}
