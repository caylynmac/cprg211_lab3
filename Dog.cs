using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Dog : Animal
    {
        public string animalType;
        public Dog()
        {
            this.animalType = "dog";
        }

        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.\n");
        }
    }
}
