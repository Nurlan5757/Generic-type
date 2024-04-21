using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nezerye.Models
{
    internal class Student
    {
        static int Count = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Credits { get; set; }
        public Group Group { get; set; }

        public Student(string name, string surname, int age, int credits, Group group)
        {
            Id = Count++;
            Name = name;
            Surname = surname;
            Age = age;
            Credits = credits;
            Group = group;
        }
    }
}
