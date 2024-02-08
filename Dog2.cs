﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Dog2 : IAnimal
    {
        public string name { get; set; }
        public string colour { get; set; }
        public string height { get; set; }
        public string age { get; set; }

        public string animalType;
        public Dog2() 
        {
            this.animalType = "Dog";
        }

        public void Eat() //don't need override keyword
        {
            Console.WriteLine("Dog's eat meat.");
        }

        public void Cry()
        {
            Console.WriteLine("Woof!\n");
        }

        public override string ToString()
        {
            return $"\nThe {colour} {animalType}'s name is {name}. He is {age} years old.";
        }
    }
}
