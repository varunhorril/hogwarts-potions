using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HogwartsPotions.Data;
using HogwartsPotions.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HogwartsPotions
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<PotionDbContext>(options => options.UseSqlServer(_config["ConnectionStrings:HogwartsPotions"]));
            services.AddSingleton<PotionRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, PotionDbContext dbContext)
        {
            app.UseMvc();
            dbContext.Seed();
        }
    }
}
