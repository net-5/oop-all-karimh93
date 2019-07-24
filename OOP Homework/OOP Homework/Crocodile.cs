using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    class Crocodile : Reptiles, ISwim, ICrawl
    {

        public Crocodile(string name) : base(name)
        {

        }

        public void Swim(double speed)
        {
            if (speed < 5)
            {
                Console.WriteLine("I'm a crocodile and i swim with a low speed.");
            }
            if (speed >= 5 && speed <= 10)
            {
                Console.WriteLine("I'm a crocodile and i swim with a cruise speed.");
            }
            else
            {
                Console.WriteLine("I cannot swim faster than 10km/h");
            }
        }


        public void Crawl(double speed)
        {
            if (speed < 5)
            {
                Console.WriteLine($"I'm {Name} and i crawl so slowly.");
            }
            if (speed >= 5 && speed <= 10)
            {
                Console.WriteLine($"I'm {Name} and i crawl with a good speed.");
            }
            else
            {
                Console.WriteLine("I cannot crawl faster than 10km/h.Please enter a lower speed.");
            }
        }
    }
}
