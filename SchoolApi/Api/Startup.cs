using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Domain.Entities.Classes.Interfaces;
using Domain.Entities.LogExceptions.Interfaces;
using Domain.Entities.Schools.Interfaces;
using Domain.Entities.Students.Interfaces;
using Infra.Data;
using Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Api
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
            services.AddControllers();

            //services.AddDbContext<DataContext>(options => options.UseSqlServer("Server=localhost;Database=pontoId;Integrated Security=True"));
            services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("c1"));

            services.AddTransient<IClassService, ClassService>();
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<ISchoolService, SchoolService>();
            
            services.AddTransient<IClassRepository, ClassRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<ISchoolRepository, SchoolRepository>();

            services.AddTransient<ILogExceptionService, LogExceptionService>();
            services.AddTransient<ILogExceptionRepository, LogExceptionRepository>();
            
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // Enable middleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();

            // Enable middleware to serve swagger-ui assets (HTML, JS, CSS etc.)
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PontoID API");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
