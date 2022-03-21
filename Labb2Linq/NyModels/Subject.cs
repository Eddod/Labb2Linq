using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2_Linq_2.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SubjectName { get; set; }
        // Many to many relationships
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
    }
}
