using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class school
    {
        private List<student> students = new List<student>();
        private  List<course> courses = new List<course>();
        private static List<Instructor> instructors = new List<Instructor>();

        public school() { }

        public void AddStudent(student student)
        {
            students.Add(student);
            Console.WriteLine($"student {student.Name} added successfully!");
        }
        
        public void AddCourse(course course)
        {
            courses.Add(course);
            Console.WriteLine($"course {course.Title} added successfully!");
        }

        public void AddInstructor(Instructor instructure)
        {
            instructors.Add(instructure);
            Console.WriteLine($"Instructor {instructure.Name} added successfully!");
        }

        public void EnrollStudentInCourse(Guid studentID, Guid courseId)
        {
            student s = FindStudent(studentID);
            course c = FindCourse(courseId);
            if (s !=null)
            {
                if(c != null)
                 s.Enroll(c);
                
            }
            else
            {
                Console.WriteLine("the student or the course is not found!");
            }
        }

        public student FindStudent(Guid studentID)
        {
            foreach(student s in students)
            {
                if(s.Id == studentID) return s;
            }

            return null;
        }

         public  course FindCourse(Guid id)
        {
            foreach (course c in courses)
            {
                if (c.Id == id) return c;
            }

            return null;
        }

        public static Instructor FindInstructor(Guid id)
        {
            foreach(Instructor i in instructors)
            {
                if(i.Id == id) return i;
            }
            return null;
        }

        public  Instructor FindInstructorbyCourse(Guid id)
        {
            foreach (course c in courses)
            {
                if (c.Id == id) return (FindInstructor(c.Instructor));
            }
            return null;
        }

        public void DisplayAllStudents()
        {
            foreach (student student in students)
            {
                Console.WriteLine(student.PrintDetails());
            }
        }
        
        public void DisplayAllCourses()
        {
            foreach (course c in courses)
            {
                Console.WriteLine(c.PrintDetails());
            }
        }

        public void DisplayAllInstructors()
        {
            foreach (Instructor i in instructors)
            {
                Console.WriteLine(i.PrintDetails());
            }
        }

        public void DeleteStudent(student s)
        {
            students.Remove(s);
            Console.WriteLine($"student {s.Name} deleted successfully!");
        }
    }
}
