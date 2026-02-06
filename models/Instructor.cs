using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class Instructor : Person
    {

        public enum Specs { Math, Arabic, English, Science } 
        public Specs Specialization { get; set; }

        public Instructor(string Name, Specs Specialization) :base(Name,0)
        {
            this.Specialization = Specialization;
        }

        public override string PrintDetails()
        {
            return base.PrintDetails() + $"specialization : {Specialization}";
        }

    }
}
