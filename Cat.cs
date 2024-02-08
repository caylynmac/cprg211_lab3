using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Cat : Animal
    {
        public string animalType;
        public Cat() 
        {
            this.animalType = "Cat";
        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.\n");
        }
    }
}
