using System;

namespace OOP_Tutorial
{
    class Car
    {
        string color;
        int maxSpeed;
    }

    abstract class Animal  // Parent class 
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();

        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig : Animal  //Child class 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  //Child class
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  //Create Pig object
            Dog myDog = new Dog();  //Create Dog object

            myPig.animalSound();
            myDog.animalSound();
            myPig.sleep();
        }
    }

}
