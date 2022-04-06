using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public Car()
        {

        }
        public bool HasDoors { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Car wants to go fast");
        }
    }
}
