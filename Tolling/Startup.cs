using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Tolling.Data;
using Tolling.Interfaces;
using Tolling.Repository;

namespace Tolling
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
            services.AddDbContext<Dbcontext>(item => item.UseSqlServer
           (Configuration.GetConnectionString("Tollingdb")));
            services.AddScoped<IUser, UserRepos>();
            services.AddScoped<ILocation, LocationRepos>();
            services.AddScoped<IPart, PartRepos>();
            services.AddScoped<ILocationDetails, LocationDetailsRepos>();
            services.AddScoped<ITool, ToolRepos>();
            services.AddScoped<ILocker, LockerRepos>();
            services.AddScoped<IRole, RoleRepos>();
            services.AddCors(options =>
            {
                options.AddPolicy("_myAllowSpecificOrigins", builder =>
builder.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader()
);
            });
                services.AddScoped<ITooling_Movement_Log, Tooling_Movement_LogRepos>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Tolling", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tolling v1"));
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors("_myAllowSpecificOrigins");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
