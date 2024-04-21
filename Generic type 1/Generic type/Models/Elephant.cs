using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type.Models
{
    internal class Elephant : Animal
    {
        public double Weight { get; set; }
        public bool IsTrained { get; set; }

        public Elephant(int avgLifeTime, string breed, int hP, Gender animalGender, double weight, bool isTrained) : base(avgLifeTime, breed, hP, animalGender)
        {
            Weight=weight;
            IsTrained=isTrained;
        }       
    }
}
