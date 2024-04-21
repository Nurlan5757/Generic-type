using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type.Models
{
    internal class ZooCage<T,U> where T : Animal where U : Food
    {
        public T _animal {  get; set; }
        public U _food { get; set; }

        public ZooCage(T animal, U food)
        {
            _animal = animal;
            _food = food;
        }
    }
}
