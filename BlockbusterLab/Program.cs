using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Blockbuster blockbuster = new Blockbuster();

            Console.WriteLine("Welcome to Blockbuster!");
            Console.WriteLine("-----------------------");

            while (true)
            {
                Console.WriteLine("Would you like to check out a movie? y to check out, any other key to exit:");
                string again = Console.ReadLine();


                if(again != "y")
                {
                    Console.WriteLine("Goodbye! Come again!");
                    break;
                }

                Console.WriteLine("Here are our current movie selections:");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();
                Console.WriteLine();


                blockbuster.CheckOut();
            }



           

        } 
    }
}
