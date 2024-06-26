using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritance_with_String_Interpolation
{
   // Define Interfaces
public interface IAnimal
    {
        string GetAnimalDetails();
        string MakeSound();
    }

    public interface IPet
    {
        string GetPetDetails();
    }

    // Base Class
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string GetBasicDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    // Derived Class Dog
    public class Dog : Animal, IAnimal, IPet
    {
        public string Breed { get; set; }

        public string GetAnimalDetails()
        {
            return $"{GetBasicDetails()}, Breed: {Breed}";
        }

        public string MakeSound()
        {
            return "Woof!";
        }

        public string GetPetDetails()
        {
            return $"This is a {Breed} dog.";
        }
    }

    // Derived Class Cat
    public class Cat : Animal, IAnimal, IPet
    {
        public string Color { get; set; }

        public string GetAnimalDetails()
        {
            return $"{GetBasicDetails()}, Color: {Color}";
        }

        public string MakeSound()
        {
            return "Meow!";
        }

        public string GetPetDetails()
        {
            return $"This is a {Color} cat.";
        }
    }

    // Main Program
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog
            {
                Name = "Buddy",
                Age = 3,
                Breed = "Golden Retriever"
            };

            Cat cat = new Cat
            {
                Name = "Whiskers",
                Age = 2,
                Color = "Gray"
            };

            Console.WriteLine("Dog Details:");
            Console.WriteLine(dog.GetAnimalDetails());
            Console.WriteLine($"Sound: {dog.MakeSound()}");
            Console.WriteLine(dog.GetPetDetails());

            Console.WriteLine("\nCat Details:");
            Console.WriteLine(cat.GetAnimalDetails());
            Console.WriteLine($"Sound: {cat.MakeSound()}");
            Console.WriteLine(cat.GetPetDetails());
        }
    }
    
}
