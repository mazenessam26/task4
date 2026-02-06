using ConsoleApp1.models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    
    internal class Program
    {
        

        



        static void Main(string[] args)
            
        {
            
            Console.WriteLine("the school program: \n");

            student s1 = new student("Mazen",23);
            student s2 = new student("Essam",25);

            Instructor i1 = new Instructor("Mr. Mohamed Ahmed",Instructor.Specs.Math);
            Instructor i2 = new Instructor("Mr. Youssed Ali",Instructor.Specs.Arabic);

            course c1 = new course("Math101", i1.Id);
            course c2 = new course("ARAB301", i2.Id);

            school s = new school();

            s.AddStudent(s1);
            s.AddStudent(s2);

            s.AddInstructor(i1);
            s.AddInstructor(i2);

            s.AddCourse(c1);
            s.AddCourse(c2);

            

            s.EnrollStudentInCourse(s1.Id, c1.Id);

            s.EnrollStudentInCourse(s2.Id, c1.Id);
            s.EnrollStudentInCourse(s2.Id, c2.Id);


            Console.WriteLine("Students:\n");
            s.DisplayAllStudents();
            Console.WriteLine("Courses:\n");
            s.DisplayAllCourses();
            Console.WriteLine("Instructors:\n");
            s.DisplayAllInstructors();

            Console.WriteLine("\n");

            Console.WriteLine($"Find student {s1.Name} :\n");
            Console.WriteLine( (s.FindStudent(s1.Id)).PrintDetails() );

            Console.WriteLine($"Find course {c2.Title} :\n");
            Console.WriteLine( (s.FindCourse(c2.Id)).PrintDetails() );

            Console.WriteLine($"is {s1.Name} enrolled in {c2.Title}?\n");
            Console.WriteLine(s1.isEnrolled(c2));
            Console.WriteLine($"\nreturning {i2.Name} details by using {c2.Title} id:");
            Console.WriteLine(s.FindInstructorbyCourse(c2.Id).PrintDetails() );
            Console.WriteLine($"\ndeleting {s1.Name}");
            s.DeleteStudent(s1);
            Console.ReadLine();

        }
    }
}