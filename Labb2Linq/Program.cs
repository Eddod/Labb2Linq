using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Labb2Linq.NyModels;
using Labb2_Linq_2.Models;

namespace Labb2Linq
{


    public class Program
    {
        public static bool CheckSubject(Context db, string subject)
        {
            using (var dbschool = new Context())
            {
                var checksubjects = (from p in dbschool.TblSubject
                                     where p.SubjectName.Contains(subject)
                                     select p).ToList();
                bool subjectexists = checksubjects.Count > 0;
                if (subjectexists)
                {
                    Console.WriteLine("The subject exists");
                }
                else
                {
                    Console.WriteLine("The subject does not exist");
                }
                return subjectexists;
            }

        }

        public static void UpdateTeacher(Context db, int ID, string newTeacher)
        {
            var TeacherList = db.TblTeacher.Find(ID);
            TeacherList.FirstName = newTeacher;
            db.Update(TeacherList);
            db.SaveChanges();


        }

        public static void StudentsTeachers(Context db)
        {
            var TeachersStudentsList = (from students in db.TblStudent
                                        join course in db.TblCourseSubject on students.CourseId equals course.CourseId
                                        join b in db.TblSubjectTeacher on course.SubjectId equals b.SubjectId
                                        join s in db.TblSubject on b.SubjectId equals s.Id
                                        join t in db.TblTeacher on b.TeacherId equals t.Id

                                        select new
                                        {
                                            StudentName = students.FirstName,
                                            TeacherName = t.FirstName,
                                            SubjectName = s.SubjectName
                                        }).ToList().Distinct();

            foreach (var item in TeachersStudentsList)
            {
                Console.WriteLine(item.StudentName + " Has " + item.TeacherName + " in " + item.SubjectName);
            }
        }

        public static void UpdateSubject(Context db, int ID, string newsubject)
        {
            var subjectList = db.TblSubject.Find(ID);
            subjectList.SubjectName = newsubject;
            db.Update(subjectList);
            db.SaveChanges();

        }
        public static void FindMathTeachers(Context db)
        {
            var mathteachers = (from st in db.TblSubjectTeacher
                                join t in db.TblTeacher on st.TeacherId equals t.Id
                                join s in db.TblSubject on st.SubjectId equals s.Id
                                where s.SubjectName == "Math"
                                select t).ToList();
            Console.WriteLine("Math teachers");
            foreach (var item in mathteachers)
            {
                Console.WriteLine("Name: " + item.FirstName + " " + item.LastName);
            }
        }
        static void Main(string[] args)
        {
            using (var DB = new Context())
            {
                FindMathTeachers(DB);
                StudentsTeachers(DB);
                CheckSubject(DB, "Programming1")
                UpdateTeacher(DB, 17, "Reidar");
                StudentsTeachers(DB);
                UpdateSubject(DB, 14, "Programming1");
                         
            }
        }
    }
}
