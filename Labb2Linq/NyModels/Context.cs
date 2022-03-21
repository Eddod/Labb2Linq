using Labb2_Linq_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2Linq.NyModels
{
    public class Context : DbContext
    {
        public DbSet<Course> TblCourse { get; set; }
        public DbSet<CourseSubject> TblCourseSubject { get; set; }
        public DbSet<Student> TblStudent { get; set; }
        public DbSet<Subject> TblSubject { get; set; }
        public DbSet<SubjectTeacher> TblSubjectTeacher { get; set; }
        public DbSet<Teacher> TblTeacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = LAPTOP-GVBM1500; Initial Catalog = LINQLABB2; Integrated Security = True");
        }
    }
}
