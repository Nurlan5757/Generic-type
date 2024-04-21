using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type.Models
{
    internal class Wolf : Animal
    {
        public bool IsPrideLeader { get; set; }
        public int AttackDamage {  get; set; }



        public Wolf(int avgLifeTime, string breed, int hP, Gender animalGender, bool isPrideLeader, int attackDamage) : base(avgLifeTime, breed, hP, animalGender)
        {
            IsPrideLeader=isPrideLeader;
            AttackDamage=attackDamage;
        }

        public void Hunt <T> (T animal) where T : Animal
        {
            animal.HP -= AttackDamage;
        }
    }
}
