﻿using System;

namespace DemoApplication  
{
    class Program
    {
        // maj note - all these are unused and unnecessary. get rid!
        

        static void Main(string[] args)
        {

			//Test
            Console.Write("Enter Your First Name: ");
            string FirstName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Your Last Name: ");
            string LastName = Convert.ToString(Console.ReadLine());

            // maj note - delete this and put it in the line below


            // maj note - you are using an empty 'Hello' variable. you can get rid of it. You also need a space for the names
            
            Console.Write ("Hello " + FirstName + " "+ LastName); 

            Console.ReadLine();
            Console.ReadKey(); // use this to stop console from exiting

            // maj note - well done on sussing the problem yourself! you'll remember it better for the future
            // next exercise - filter out numerical values. you will need to lookup how to use if-statements, good luck!

            //Vicky waz ere 2k18 LAR
        }
    }
}