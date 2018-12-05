using System;

namespace DemoApplication  
{
    class Program
    {
        public static string LastName { get; private set; }
        public static string FirstNameLastName { get; private set; }

        static void Main(string[] args)
        {

			//Test
            Console.Write("Enter Your First Name: ");
            string FirstName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Your Last Name: ");
            String str = "Hello firstname lastname";

            Console.WriteLine("Hello " + FirstNameLastName);

            Console.ReadLine();
            Console.ReadKey(); // use this to stop console from exiting
        }
    }
}