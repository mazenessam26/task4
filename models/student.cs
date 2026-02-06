using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class student : Person
    {
        private List<course> courses = new List<course>();

        public student(string Name,int Age) : base(Name, Age)
        {
            
        }

        public override string PrintDetails()
        {
            return base.PrintDetails() + $"age: {Age}";
        }

        public bool Enroll(course course)
        {
            
            courses.Add(course);
            return true;
        }

        public bool isEnrolled(course c)
        {
            foreach(course course in courses)
            {
                if(c==course) return true;
            }
            return false;
        }

    }
}
