using Microsoft.EntityFrameworkCore;
using Labb2_Linq_2.Models;
using Labb2Linq.NyModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace Labb2Linq
{
    public class Logic
    {
        public static void AddData(Context DB)
        {

            var subjects = new List<Subject>()
                        {
                            new Subject {SubjectName = "Math"},
                            new Subject {SubjectName = "Programming1"},
                            new Subject {SubjectName = "Advanced.NET"},
                            new Subject {SubjectName = "History"},
                            new Subject {SubjectName = "Economy"},
                            new Subject {SubjectName = "Business"},
                        };

            var courses = new List<Course>()
                        {
                            new Course{CourseName = "SUT21"},
                            new Course{CourseName = "SUT22"},
                            new Course{CourseName = "SUT23"},
                        };

            var teachers = new List<Teacher>()
                        {
                            new Teacher {FirstName = "Anas", LastName = "Qlok", Role = "Teacher"},
                            new Teacher {FirstName = "Reidar", LastName = "Nilsen", Role = "Teacher"},
                            new Teacher {FirstName = "Kalle", LastName = "Karlsson", Role = "Teacher"},
                            new Teacher {FirstName = "Perry", LastName = "Svahn", Role = "Teacher"},
                            new Teacher {FirstName = "Mats", LastName = "Ohlsson", Role = "Teacher"},
                            new Teacher {FirstName = "Roland", LastName = "Svansson", Role = "Teacher"},
                            new Teacher {FirstName = "Karl", LastName = "Pettersson", Role = "Teacher"},
                            new Teacher {FirstName = "Vilma", LastName = "Skog", Role = "Teacher"},
                        };
            var students = new List<Student>()
                        {
                            new Student {FirstName = "Edwin", LastName = "Westerberg", CourseId = 1},
                            new Student {FirstName = "Hanna", LastName = "Hällqvist", CourseId = 1},
                            new Student {FirstName = "Anna", LastName = "Anka", CourseId = 1},
                            new Student {FirstName = "Sven", LastName = "Son", CourseId = 2},
                            new Student {FirstName = "Bingo", LastName = "Lotto", CourseId = 2},
                            new Student {FirstName = "Harry", LastName = "Potter", CourseId = 2},
                            new Student {FirstName = "King", LastName = "Kong", CourseId = 3},
                            new Student {FirstName = "Benny", LastName = "Persson", CourseId = 3},
                            new Student {FirstName = "Svenny", LastName = "Svensson", CourseId = 3},
                        };

            var coursesubjects = new List<CourseSubject>()
                        {
                            new CourseSubject{CourseId = 1, SubjectId = 1},
                            new CourseSubject{CourseId = 1, SubjectId = 2},
                            new CourseSubject{CourseId = 1, SubjectId = 3},
                            new CourseSubject{CourseId = 2, SubjectId = 1},
                            new CourseSubject{CourseId = 2, SubjectId = 4},
                            new CourseSubject{CourseId = 2, SubjectId = 5},
                            new CourseSubject{CourseId = 3, SubjectId = 6},
                            new CourseSubject{CourseId = 3, SubjectId = 5},
                            new CourseSubject{CourseId = 3, SubjectId = 1},
                        };

            var subjectTeachers = new List<SubjectTeacher>()
                        {
                            new SubjectTeacher{SubjectId = 1, TeacherId = 1},
                            new SubjectTeacher{SubjectId = 1, TeacherId = 2},
                            new SubjectTeacher{SubjectId = 2, TeacherId = 3},
                            new SubjectTeacher{SubjectId = 3, TeacherId = 4},
                            new SubjectTeacher{SubjectId = 4, TeacherId = 5},
                            new SubjectTeacher{SubjectId = 5, TeacherId = 6},
                            new SubjectTeacher{SubjectId = 4, TeacherId = 6},
                            new SubjectTeacher{SubjectId = 2, TeacherId = 7},
                            new SubjectTeacher{SubjectId = 6, TeacherId = 8},
                        };
            DB.AddRange(subjects);
            DB.AddRange(courses);
            DB.AddRange(teachers);
            DB.AddRange(students);
            DB.AddRange(coursesubjects);
            DB.AddRange(subjectTeachers);
            DB.SaveChanges();


        }
        
            
        
            
        
        
    }


}
