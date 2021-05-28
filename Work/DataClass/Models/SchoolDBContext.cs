using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataClass
{
    public partial class SchoolDBContext : DbContext
    {
        public SchoolDBContext()
        {
        }

        public SchoolDBContext(DbContextOptions<SchoolDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseTeacher> CourseTeachers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Enrolment> Enrolments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherDepartment> TeacherDepartments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SchoolDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Course__Departme__00200768");
            });

            modelBuilder.Entity<CourseTeacher>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.TeacherId })
                    .IsClustered(false);

                entity.ToTable("CourseTeacher");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseTeachers)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseTeacher_Course");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.CourseTeachers)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseTeacher_Teacher");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Enrolment>(entity =>
            {
                entity.ToTable("Enrolment");

                entity.Property(e => e.EnrolmentDate).HasColumnType("date");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Enrolments)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Enrolment__Cours__7E37BEF6");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Enrolments)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Enrolment__Stude__2B3F6F97");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Addr).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.HomePhone).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MobilePhone).IsUnicode(false);

                entity.Property(e => e.Nickname).IsUnicode(false);

                entity.Property(e => e.Passcode).IsUnicode(false);

                entity.Property(e => e.Postcode).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");

                entity.HasIndex(e => e.Username, "UQ__tmp_ms_x__536C85E4D16FFE05")
                    .IsUnique();

                entity.Property(e => e.Addr).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Passcode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode).IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TeacherDepartment>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentId, e.TeacherId })
                    .IsClustered(false);

                entity.ToTable("TeacherDepartment");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TeacherDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherDepartment_Department");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherDepartments)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherDepartment_Teacher");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
