using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectEditor.Application.Bootstrap;
using ProjectEditor.Application.Devices;
using ProjectEditor.Persistence.Bootstrap;
using ProjectEditor.Persistence.Repositories.DBContext;
using System.Reflection;


namespace ProjectEditor.WS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            /* Connection String für DB Zugriff*/
            var connectionString = Configuration.GetConnectionString("ProjectEditorDbContextLocal");
            services.AddDbContext<ProjectEditorDbContext>(options => options.UseSqlServer(connectionString));

            // Query und Command registrieren
            services.RegisterApplicationServices();

            // Repositories registrieren
            services.RegisterRepositories();

            // MediatR inkl. Handler registrieren
            services.AddMediatR(typeof(DeviceQueryHandler).GetTypeInfo().Assembly);

            //services.AddCors();

            services.AddSwaggerGen(g =>
            {
                g.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "ProjectEditor - Service", Version = "v1" });

            });


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Swagger UI konfigurieren
            app.UseSwagger();
            app.UseSwaggerUI(ui =>
            {
                ui.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjectEdior - Service");

            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<ProjectEditorDbContext>();
                dbContext.Database.Migrate();
            }
        }
    }
}
