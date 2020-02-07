using System;

namespace OOP_Tutorial
{
    class Car
    {
        string color = "red";

        static void Main (string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}
