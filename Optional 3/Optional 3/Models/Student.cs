using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_3.Models
{
    internal class Student
    {
        public string Name { get; set; }
        public bool IsPlagiated {  get; set; }=true;
        public bool IsHelpedToPlagiate { get; set; } = true;

        public Student(string name, bool isPlagiated,bool isHelpedToPlagiate)
        {
            Name = name;
            IsPlagiated = isPlagiated;
            IsHelpedToPlagiate = isHelpedToPlagiate;
        }
    }
}
