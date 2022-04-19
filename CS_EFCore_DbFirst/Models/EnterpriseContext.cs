using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CS_EFCore_DbFirst.Models
{
    public partial class EnterpriseContext : DbContext
    {
        public EnterpriseContext()
        {
        }

        public EnterpriseContext(DbContextOptions<EnterpriseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DepartmentTxAudit> DepartmentTxAudits { get; set; } = null!;
        public virtual DbSet<DeptEmp> DeptEmps { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeAudit> EmployeeAudits { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        /// <summary>
        /// USes the Connection String
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Enterprise;Integrated Security=SSPI");
            }
        }

        /// <summary>
        /// The Fluent API Code to Define Relationships Across Tables
        /// and mapping of CLR CLasses (ENtities) with DB Tables
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Comment1)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Comment");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptNo)
                    .HasName("PK__Departme__0148CAAE20A0829D");

                entity.ToTable("Department");

                entity.HasIndex(e => e.DeptName, "DeptName_Unique")
                    .IsUnique();

                entity.Property(e => e.DeptNo).ValueGeneratedNever();

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepartmentTxAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK__Departme__A17F2398894347CF");

                entity.ToTable("DepartmentTxAudit");

                entity.Property(e => e.AuditDate).HasColumnType("date");

                entity.Property(e => e.AuditType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeptEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DeptEmp");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpNo)
                    .HasName("PK__Employee__AF2D66D3CDE537B6");

                entity.ToTable("Employee");

                entity.Property(e => e.EmpNo).ValueGeneratedNever();

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(300)
                    .IsUnicode(false);
                // One to Many
                entity.HasOne(d => d.DeptNoNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DeptNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__DeptNo__267ABA7A");
            });

            modelBuilder.Entity<EmployeeAudit>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK__Employee__A17F2398B5C5B8F9");

                entity.ToTable("EmployeeAudit");

                entity.Property(e => e.AudiDate).HasColumnType("date");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UQ__Users__C9F28456C90989A8")
                    .IsUnique();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
