using Demo.Application.Interfaces;
using Demo.Application.Services;
using Demo.Domain.Interfaces;
using Demo.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
