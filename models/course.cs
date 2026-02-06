using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class course : general
    {
        public Guid Id { get; set; }
        public string Title {  get; set; }
        public Guid Instructor { get; set; }

        public course(string Title, Guid instructor)
        {
            this.Id = Guid.NewGuid();
            this.Title = Title;
            this.Instructor = instructor;
        }


        public string PrintDetails()
        {
            return $"id: {Id} course name: {Title} , course instructor: {school.FindInstructor(Instructor).Name}";
        }

        
    }
}
