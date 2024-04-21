using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nezerye.Models
{
    internal class Group
    {
        static int Count = 1;
        public int Id { get; }
        public string Name { get; set; }


        public Group(string name)
        {
            Name = name;
            Id = Count++;
        }
    }
}
