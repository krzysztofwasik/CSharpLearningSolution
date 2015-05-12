using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternExample1
{
    enum Animals
    {
        Cat, Dog, Wolf
    }
    
    /// <summary>
    /// Interface describing behaviour of target classes
    /// </summary>
    interface IAnimal
    {
        void MakeSount();
    }

    /// <summary>
    /// Class describing cat behaviour
    /// </summary>
    class Cat : IAnimal
    {
        public void MakeSount()
        {
            Console.WriteLine("Miauuuuu!");
        }
    }

    /// <summary>
    /// Classs describing dog behaviour
    /// </summary>
    class Dog : IAnimal
    {
        public void MakeSount()
        {
            Console.WriteLine("Hauuuuu!");
        }
    }

    /// <summary>
    /// Class describing wolf behaviour
    /// </summary>
    class Wolf : IAnimal
    {
        public void MakeSount()
        {
            Console.WriteLine("Auuuu!");
        }
    }

    /// <summary>
    /// Class inmplementing factory method patter for creating instances which shares IAnimal interface
    /// </summary>
    static class AnimalFactory
    {
        public static IAnimal CreateAnimalObject(Animals animalType)
        {
            IAnimal animal = null;

            switch (animalType)
            {
                case Animals.Cat:
                    animal = new Cat();
                    break;
                case Animals.Dog:
                    animal = new Dog();
                    break;
                case Animals.Wolf:
                    animal = new Wolf();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("animalType","Provided animal type is not supported");
            }
            
            return animal;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = AnimalFactory.CreateAnimalObject(Animals.Dog);
            animal.MakeSount();
                       
            Console.ReadKey();
        }
    }
}
