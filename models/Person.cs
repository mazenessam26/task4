using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class Person : general
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        

        public Person(string name, int age) 
        { 
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            
        }

        public Person(string name)
        { 
            Name = name;
        }

        public virtual string PrintDetails()
        {
            return $"id: {Id} , name : {Name} ";
        }

    }
}
