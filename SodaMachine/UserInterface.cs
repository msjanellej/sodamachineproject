using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

            Console.WriteLine("Please choose '1' for Root Beer, '2' for Cola, or '3' for Orange Soda");
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
        public static void NoInventoryAvailable()
        {
            Console.WriteLine();
            Console.WriteLine("Unable to vend. No inventory available");
        }
        //public static double PickCoins() //issue is that this doesn't compare to items on the list. 
        //{
        //    Console.WriteLine("Please choose which coins you would like to use");
        //    Console.WriteLine("Please choose '1' for quarter, '2' for dime, '3' for nickle, or '4' for penny");
        //    Console.WriteLine("If you are done choosing coins please enter '0'");
        //    double coins = double.Parse(Console.ReadLine());
        //    double chosenCoin = 0;
        //    while (coins != 0)
        //    {
        //        switch (coins)
        //        {
        //            case 1:
        //                if (Customer.wallet.coins.name == "quarter")
        //                {
        //                    Console.WriteLine();
        //                    Console.WriteLine("You have chosen a quarter");
        //                    chosenCoin = 0.25;
        //                    break;
        //                }
        //                else
        //                {
        //                    Console.WriteLine();
        //                    Console.WriteLine("You don't have any quarters in your wallet");
        //                }
                        
        //            case 2:
        //                Console.WriteLine();
        //                Console.WriteLine("You have chosen a dime");
        //                chosenCoin = .10;
        //                break;
        //            case 3:
        //                Console.WriteLine();
        //                Console.WriteLine("You have chosen a nickle");
        //                chosenCoin = .05;
        //                break;
        //            case 4:
        //                Console.WriteLine();
        //                Console.WriteLine("You have chosen a penny");
        //                chosenCoin = .01;
        //                break;
        //            default:
        //                Console.WriteLine();
        //                Console.WriteLine("You have chosen to not enter more coins");
        //                chosenCoin = 0;
        //                break;
        //        }
        //        chosenCoin += chosenCoin;
        //    }
        //    return chosenCoin; 

            
       // }
    }
}
