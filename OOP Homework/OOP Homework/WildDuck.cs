using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    class WildDuck:Birds,IFly,IWalk
    {


        public WildDuck(string name):base(name)
        {

        }

        public void Fly(double speed)
        {
            if (speed < 15)
            {
                Console.WriteLine($"I'm {Name},i am tired and i am flying slowly");
            }
            else
            {
                Console.WriteLine($"I'm {Name} and i am dancing in the sky");
            }
        }

        public void Walk(double speed)
        {
            if (speed < 5)
            {
                Console.WriteLine("I'm a wild duck and i walk so slow.");
            }
            if (speed >= 5 && speed <= 10)
            {
                Console.WriteLine("I'm an and i walk with a medium speed.");
            }
            else
            {
                Console.WriteLine("This speed is driving me crazy");
            }
        }

    }
}
