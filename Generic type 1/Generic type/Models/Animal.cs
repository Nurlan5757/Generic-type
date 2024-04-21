using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type.Models
{
    internal abstract class Animal
    {

        public enum Gender 
        {
            male,
            female
        }


        public int AvgLifeTime { get; set; }  
        public string Breed { get; set; }
        public int HP { get; set; }=100;
        public Gender _gender { get; set; }


        public Animal(int avgLifeTime, string breed, int hP, Gender gender )
        {
            AvgLifeTime=avgLifeTime;
            Breed=breed;
            HP=hP;
            _gender = gender;
        } 
    }
}
