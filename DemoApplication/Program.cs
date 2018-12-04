using System;

namespace DemoApplication  
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Your First Name: ");
            string FirstName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Your Last Name: ");

            Console.ReadLine();
            Console.ReadKey(); // use this to stop console from exiting
        }
    }
}