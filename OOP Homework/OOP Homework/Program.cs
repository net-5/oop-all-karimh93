using System;

namespace OOP_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Salmon salmon = new Salmon("Max");
            salmon.Swim(10);

            Console.WriteLine("----------------");

            Ant ant = new Ant("Ann");
            ant.Crawl(2);

            Console.WriteLine("----------------");

            Crocodile croco = new Crocodile("Thor"); ;
            croco.Crawl(11);

        }
    }
}
