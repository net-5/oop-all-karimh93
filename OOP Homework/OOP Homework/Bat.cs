using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    class Bat:Mammals ,IFly
    {

        public Bat(string name):base(name)
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
                Console.WriteLine($"I'm {Name} and flying like a Batman");
            }
        }


    }
}
