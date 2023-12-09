using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employer>()
                .Property(e => e.EmployerUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Employer>()
                .Property(e => e.EmployerPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .Property(e => e.FacultyID)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Majors)
                .WithRequired(e => e.Faculty)
                .HasForeignKey(e => e.MajorFaculty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Faculty)
                .HasForeignKey(e => e.StudentFaculty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Major>()
                .Property(e => e.MajorID)
                .IsUnicode(false);

            modelBuilder.Entity<Major>()
                .Property(e => e.MajorFaculty)
                .IsUnicode(false);

            modelBuilder.Entity<Major>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Major)
                .HasForeignKey(e => e.StudentMajor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentFaculty)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentMajor)
                .IsUnicode(false);
        }
    }
}
