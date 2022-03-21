using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2_Linq_2.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Role { get; set; }
        // Many to many relationship
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
    }
}
