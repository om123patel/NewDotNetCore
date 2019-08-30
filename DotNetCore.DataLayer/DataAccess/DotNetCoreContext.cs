using DotNetCore.DataLayer.Mapping;
using DotNetCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace DotNetCore.DataLayer
{
    public class DotNetCoreContext : DbContext
    {
        #region Constructor
        public DotNetCoreContext() : base()
        {

        }

        public DotNetCoreContext(DbContextOptions<DotNetCoreContext> options) : base(options)
        {

        }
        #endregion

        #region Override DbContext Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //The default schema that EF Core uses to create database obejcts is dbo. You can change this behaviour using the ModelBuilder's HasDefaultSchema method:
            modelBuilder.HasDefaultSchema("dbo");

            //Here - Apply Field Mapping Configuration 
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new DesignationMap());
            modelBuilder.ApplyConfiguration(new DepartmentMap());
            modelBuilder.ApplyConfiguration(new EmployeeMap());

            modelBuilder.ApplyConfiguration(new CountryMap());
            modelBuilder.ApplyConfiguration(new StateMap());

            //Table Per Hierarchy Inheritance (Example)
            modelBuilder.ApplyConfiguration(new ContractMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Required Packages for Set Configuration in Class Library
            //Microsoft.Extensions.Configuration.FileExtensions
            //Microsoft.Extensions.Configuration.Json
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyConnection"));
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                    && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    long identityName = 1;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedOn = now;
                    }
                    else if (entry.State == EntityState.Modified)
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedOn).IsModified = false;

                        entity.UpdatedBy = identityName;
                        entity.UpdatedOn = now;
                    }
                    else if (entry.State == EntityState.Deleted)
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedOn).IsModified = false;

                        entity.UpdatedBy = identityName;
                        entity.UpdatedOn = now;
                    }
                    
                }
            }

            return base.SaveChanges();
        }
        #endregion

        #region DbSet Entity

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }


        #endregion
    }
}
