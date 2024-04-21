using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type.Models
{
    internal class Meat : Food
    {
        public enum Type
        {
            Beef,
            Chicken,
            Fish,
        }

        public Type _type {  get; set; }

        public Meat(int calorie,Type type) : base(calorie)
        {
            _type = type;
        }
    }
}
