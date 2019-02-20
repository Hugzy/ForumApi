using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumApi.Api.Context;
using ForumApi.Providers.test;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ForumApi
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
            services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase());
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            TestProvider.getInstance()
                //Add test data for posts in the in-memory database
                .AddTestPosts(app.ApplicationServices.GetService<ApiContext>())
                //Add test data for forums in the in-memory database
                .AddTestForums(app.ApplicationServices.GetService<ApiContext>())
                //Add test data for threads in the in-memory database
                .AddTestThreads(app.ApplicationServices.GetService<ApiContext>());

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}