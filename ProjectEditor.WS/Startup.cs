using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ProjectEditor.Application.Authentication;
using ProjectEditor.Application.Bootstrap;
using ProjectEditor.Application.Devices;
using ProjectEditor.Common.Services;
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

            // User Service registrieren
            services.AddScoped<IUserService, UserService>();

            services.AddAuthentication("BasicAuthentication")
                    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            // MediatR inkl. Handler registrieren
            services.AddMediatR(typeof(DeviceQueryHandler).GetTypeInfo().Assembly);

            //services.AddCors();

            services.AddSwaggerGen(g =>
            {
                g.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "ProjectEditor - Service", Version = "v1" });



                // Button für Authorisierung in Swagger
                g.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the basic Scheme!"
                });

                g.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                        Reference = new OpenApiReference
                        {
                            Type=ReferenceType.SecurityScheme,
                            Id ="basic"
                        }
                    },
                    new string[] {}
                }
                });
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

            app.UseAuthentication(); 
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
