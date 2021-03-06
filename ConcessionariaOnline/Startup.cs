using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ConcessionariaOnline.Models.Swagger;
using Microsoft.EntityFrameworkCore;
using ConcessionariaOnline.Models.ConcessionariaOnlineContext;
using ConcessionariaOnline.Interfaces;
using ConcessionariaOnline.Facades;

namespace ConcessionariaOnline
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
            string ConnectionString = Configuration.GetConnectionString("ConcessionariaString");

            services.AddDbContext<ConcessionariaOnlineContext>(opt => 
            {
                opt.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));
            }); 

            services.AddControllersWithViews();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });

            // Setting up swagger
            IServiceCollection serviceCollection = services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Swagger Demo",
                    Description = "Swagger Demo for ValuesController",
                    TermsOfService = "None",
                    Contact = new Contact() { Name = "Matheus Rocha", Email = "matheusrocha@gmail.com", Url = "www.google.com" }
                });
            });

            // Inje????o de depend??ncia
            services.AddScoped<IUserFunctions, UserFunctions>();
            services.AddScoped<IOrders, Orders>();
            services.AddScoped<ICar, Cars>();
            services.AddScoped<IClient, Client>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Concession??ria Online");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
