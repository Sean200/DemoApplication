using System;

namespace DemoApplication  
{
    class Program
    {
        public static string LastName { get; private set; }
        public static string FirstNameLastName { get; private set; }
        public static object MessageBox { get; private set; }
        public static string Hello { get; private set; }

        static void Main(string[] args)
        {

			//Test
            Console.Write("Enter Your First Name: ");
            string FirstName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Your Last Name: ");
            string LastName = Convert.ToString(Console.ReadLine());
            Console.Write("Hello ");

            Console.Write (Hello + FirstName + LastName, "Concatenation"); 

            Console.ReadLine();
            Console.ReadKey(); // use this to stop console from exiting
        }
    }
}