using DotNetCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCore.DataLayer.Mapping
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.Property(d => d.Id).ValueGeneratedOnAdd();
            builder.Property(d => d.FirstName).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(d => d.MiddleName).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(d => d.LastName).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(d => d.Code).IsRequired().HasMaxLength(20).IsUnicode(false);
            builder.Ignore(d => d.FullName);

            builder.Property(e => e.CreatedOn).IsRequired().HasColumnType("datetime");
            builder.Property(e => e.UpdatedOn).HasColumnType("datetime");
            builder.Property(e => e.DeletedOn).HasColumnType("datetime");

            builder.Property(e => e.CreatedBy).IsRequired();
            builder.HasOne(d => d.UserCreatedBy)
                .WithMany(p => p.EmployeeCreatedBy)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_User_CreatedBy");

            builder.HasOne(d => d.UserUpdatedBy)
                .WithMany(p => p.EmployeeUpdatedBy)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK_Employee_User_UpdatedBy");

            builder.HasOne(d => d.UserDeletedBy)
                .WithMany(p => p.EmployeeDeletedBy)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK_Employee_User_DeletedBy");

            builder.Property(e => e.DepartmentId).IsRequired();

            builder.HasOne(d => d.Department)
                 .WithMany(p => p.Employees)
                 .HasForeignKey(d => d.DepartmentId)
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("FK_Employee_Department");

            builder.Property(e => e.DesignationId).IsRequired();
            builder.HasOne(d => d.Designation)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.DesignationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_Designation");

            builder.Property(e => e.IsActive).HasDefaultValue(true);
            builder.Property(e => e.IsDeleted).HasDefaultValue(false);
            builder.Property(e => e.CreatedOn).HasDefaultValueSql("GetUtcDate()");

            //Concurrency Management in Entity Framework Core 
            //https://www.learnentityframeworkcore.com/concurrency
            //builder.Property(a => a.TimeStamp).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();

        }
    }
}
