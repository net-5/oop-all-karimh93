using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    class Platypus:Mammals,IWalk, ISwim
    {
        public Platypus(string name):base(name)
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
                Console.WriteLine("I'm a platypus,i want to fly,but i can't.");
            }
        }
        public void Swim(double speed)
        {

        }


    }
}
