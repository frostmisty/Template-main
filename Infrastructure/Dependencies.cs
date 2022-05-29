﻿using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class Dependencies
    {
        public static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            //services.AddDbContext<MainTemplateContext>(x =>x.UseSqlServer(configuration.GetConnectionString("MainConnection")));

            services.AddDbContext<MainTemplateContext>(x =>x.UseSqlServer(configuration.GetConnectionString("LocalConnection")));
        }
    }
}
