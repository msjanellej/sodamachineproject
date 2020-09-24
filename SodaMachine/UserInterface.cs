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
        public static void ChooseSoda()
        {
            Console.WriteLine("Please select the soda you would like:");
            Console.WriteLine("type 'cola' for cola");
            Console.WriteLine("type 'rootbeer' for root beer");
            Console.WriteLine("type 'orange' for orange soda");
            string soda = Console.ReadLine();
        }
    }
}
