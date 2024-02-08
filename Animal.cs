using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class Animal
    {
        public string name { get; set; }
        public string colour { get; set; }
        public int age { get; set; }

        public Animal() 
        {
        }
        public abstract void Eat();
    }
}
