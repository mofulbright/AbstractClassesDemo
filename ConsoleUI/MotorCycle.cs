using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class MotorCycle : Vehicle
    {
        public MotorCycle()
        {

        }
        public bool HasTwoWheels {  get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle goes zoom zoom");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is so fast");
        }
    }
}
