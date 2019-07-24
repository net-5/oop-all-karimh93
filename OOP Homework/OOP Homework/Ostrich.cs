using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    class Ostrich : Birds, IWalk
    {
        public Ostrich(string name) : base(name)
        {

        }

        public void Walk(double speed)
        {
            if (speed < 5)
            {
                Console.WriteLine($"I'm {Name} and i walk so slow.");
            }
            if (speed >= 5 && speed <= 10)
            {
                Console.WriteLine($"I'm {Name} and i walk with a medium speed.");
            }
            else
            {
                Console.WriteLine("I cannot walk faster than 10km/h.Please enter a lower speed.");
                
            }
        }
    }
}

