using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Cat2 : IAnimal
    {
        public string name { get; set; }
        public string colour { get; set; }
        public string height { get; set; }
        public string age { get; set; }

        public string animalType;
        public Cat2()
        {
            this.animalType = "Cat";
        }

        public void Eat() //don't need override keyword
        {
            Console.WriteLine("Cat's eat mice.");
        }

        public void Cry()
        {
            Console.WriteLine("Meow!\n");
        }

        public override string ToString()
        {
            return $"\nThe {colour} {animalType}'s name is {name}. He is {age} years old.";
        }
    }
}
