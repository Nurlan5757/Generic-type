using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type.Models
{
    internal class Grass : Food
    {
        public string Name { get; set; }

        public Grass(int calorie, string name) : base(calorie)
        {
            Name = name;
        }
    }
}
