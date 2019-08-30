using DotNetCore.DataLayer;
using DotNetCore.Repository;
using DotNetCore.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DotNetCore.Web.Infrastructure
{
    public static class UnitOfWorkServiceCollectionExtentions
    {
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<ICountryRepository, CountryRepository>();

            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();

            services.AddTransient<IDesignationService, DesignationService>();
            services.AddTransient<IDesignationRepository, DesignationRepository>();
            
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();



            return services;
        }

        public static IServiceCollection AddLifeTimeOfDependancyInjectionTest(this IServiceCollection services)
        {
            services.AddTransient<IOperationTransient, Operation>();
            services.AddScoped<IOperationScoped, Operation>();
            services.AddSingleton<IOperationSingleton, Operation>();
            services.AddSingleton<IOperationSingletonInstance>(new Operation(Guid.Empty));
            services.AddTransient<IOperationService, OperationService>();
            return services;
        }

        //public static IServiceCollection AddUnitOfWork<TContext>(this IServiceCollection services)
        //    where TContext : DbContext
        //{
        //    services.AddScoped<IRepositoryFactory, UnitOfWork<TContext>>();
        //    services.AddScoped<IUnitOfWork, UnitOfWork<TContext>>();
        //    services.AddScoped<IUnitOfWork<TContext>, UnitOfWork<TContext>>();
        //    return services;
        //}

        //public static IServiceCollection AddUnitOfWork<TContext1, TContext2>(this IServiceCollection services)
        //    where TContext1 : DbContext
        //    where TContext2 : DbContext
        //{
        //    services.AddScoped<IUnitOfWork<TContext1>, UnitOfWork<TContext1>>();
        //    services.AddScoped<IUnitOfWork<TContext2>, UnitOfWork<TContext2>>();
        //    return services;
        //}

        //public static IServiceCollection AddUnitOfWork<TContext1, TContext2, TContext3>(
        //    this IServiceCollection services)
        //    where TContext1 : DbContext
        //    where TContext2 : DbContext
        //    where TContext3 : DbContext
        //{
        //    services.AddScoped<IUnitOfWork<TContext1>, UnitOfWork<TContext1>>();
        //    services.AddScoped<IUnitOfWork<TContext2>, UnitOfWork<TContext2>>();
        //    services.AddScoped<IUnitOfWork<TContext3>, UnitOfWork<TContext3>>();

        //    return services;
        //}

        //public static IServiceCollection AddUnitOfWork<TContext1, TContext2, TContext3, TContext4>(
        //    this IServiceCollection services)
        //    where TContext1 : DbContext
        //    where TContext2 : DbContext
        //    where TContext3 : DbContext
        //    where TContext4 : DbContext
        //{
        //    services.AddScoped<IUnitOfWork<TContext1>, UnitOfWork<TContext1>>();
        //    services.AddScoped<IUnitOfWork<TContext2>, UnitOfWork<TContext2>>();
        //    services.AddScoped<IUnitOfWork<TContext3>, UnitOfWork<TContext3>>();
        //    services.AddScoped<IUnitOfWork<TContext4>, UnitOfWork<TContext4>>();

        //    return services;
        //}
    }
}