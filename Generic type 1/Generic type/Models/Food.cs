using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type.Models
{
    internal abstract class Food
    {
        public int Calorie {  get; set; }

        protected Food(int calorie)
        {
            Calorie=calorie;
        }

    }
}
