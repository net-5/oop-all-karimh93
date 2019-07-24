using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    class Ant:Insects,ICrawl
    {

        public Ant(string name):base(name)
        {

        }

        public void Crawl(double speed)
        {
            if (speed < 1)
            {
                Console.WriteLine($"I'm {Name} and i crawl so slowly.");
            }
            if (speed >= 1 && speed <= 3)
            {
                Console.WriteLine($"I'm a {Name} and i crawl with a good speed.");
            }
            else
            {
                Console.WriteLine("I cannot crawl faster than 3km/h.Please enter a lower speed.");

            }
        }

    }
}
