using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2_Linq_2.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        // One to many relationship
        public ICollection<Student> Students { get; set; }
        // Many to many relationship
        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
    }
}
