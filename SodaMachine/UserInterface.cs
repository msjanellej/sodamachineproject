using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    static class UserInterface
    {
        //member variables
        
        

        // constructor
        static UserInterface()
        {
          
        }
       

        // member methods
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome. Please select your soda");
        }
        public static void ThankYou()
        {
            Console.WriteLine("Thank you and have a nice day");
        }
        public static void InsufficientFunds()
        {
            Console.WriteLine("Unable to purchase soda. Insufficient Funds");
        }
        public static int ChooseSoda()
        {
            bool condition = true;

            Console.WriteLine("Please choose '1' for Root Beer, '2' for Cola, or '3' for Orange Soda";
            int sodaSelection = int.Parse(Console.ReadLine());
            while (condition)
            {
                switch (sodaSelection)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("You have chosen rootbeer");
                        condition = false;
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("You have chosen Cola");
                        condition = false;
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("You have chosen Orange Soda");
                        condition = false;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("You did not make a valid selection");
                        condition = true;
                        break;
                }
            }
            return sodaSelection;
        }
    }
}
