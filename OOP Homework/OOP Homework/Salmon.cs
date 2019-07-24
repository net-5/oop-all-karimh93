using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    class Salmon:Fish,ISwim
    {

        public Salmon(string name):base(name)
        {

        }

        public void Swim(double speed)
        {
            if (speed < 5)
            {
                Console.WriteLine($"I'm {Name} and i swim with a low speed.");
            }
            if (speed >= 5 && speed <= 10)
            {
                Console.WriteLine($"I'm {Name} and i swim with a cruise speed.");
            }
            else
            {
                Console.WriteLine("I am swimming fast because i want to capture some little fishes");
            }
        }

    }
}
