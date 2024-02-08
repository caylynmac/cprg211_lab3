namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1 abstract classes
            //dog
            Console.WriteLine("What is your dog's name?");
            string dogName1 = Console.ReadLine();
            Dog dog1 = new Dog();

            dog1.name = dogName1;
            dog1.colour = "brown";
            dog1.age = 2;

            Console.WriteLine($"The {dog1.colour} {dog1.animalType}'s name is {dog1.name}. He is {dog1.age} years old.");
            dog1.Eat();

            //cat
            Console.WriteLine("What is your cat's name?");
            string catName1 = Console.ReadLine();
            Cat cat1 = new Cat();

            cat1.name = catName1;
            cat1.colour = "brown";
            cat1.age = 2;

            Console.WriteLine($"The {cat1.colour} {cat1.animalType}'s name is {cat1.name}. He is {cat1.age} years old.");
            cat1.Eat();

            //part 2 interfaces

            Dog2 dog2 = new Dog2();

            Console.WriteLine("What is your dog's name?");
            dog2.name = Console.ReadLine();
            Console.WriteLine("What is it's height?");
            dog2.height = Console.ReadLine();
            Console.WriteLine("What colour is it?");
            dog2.colour = Console.ReadLine();
            Console.WriteLine("How old is it?");
            dog2.age = Console.ReadLine();

            Console.WriteLine(dog2);
            dog2.Eat();
            dog2.Cry();

            //cat

            Cat2 cat2 = new Cat2();

            Console.WriteLine("What is your cat's name?");
            cat2.name = Console.ReadLine();
            Console.WriteLine("What is it's height?");
            cat2.height = Console.ReadLine();
            Console.WriteLine("What colour is it?");
            cat2.colour = Console.ReadLine();
            Console.WriteLine("How old is it?");
            cat2.age = Console.ReadLine();

            Console.WriteLine(cat2);
            cat2.Eat();
            cat2.Cry();

            //list of interface animals
            List<IAnimal> animals = new List<IAnimal>();

            animals.Add(dog2);
            animals.Add(cat2);

            Cat2 cat3 = new Cat2();
            cat3.name = "Mr.Whiskers";
            animals.Add(cat3);

            Cat2 cat4 = new Cat2();
            cat4.name = "Sebastian";
            animals.Add(cat4);

            Console.Write("\nThe animals names are:\n");
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.name);
            }
        }
    }
}
