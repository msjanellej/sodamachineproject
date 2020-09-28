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
            Console.WriteLine("Root Beer is $.60");
            Console.WriteLine("Cola is $.35");
            Console.WriteLine("Orange Soda is $.06");
            Console.WriteLine();
        }
        public static void ThankYou()
        {
            Console.WriteLine("Thank you and have a nice day");
        }
        public static void InsufficientFunds()
        {
            Console.WriteLine("Unable to purchase soda. Insufficient Funds");
        }
        public static string ChooseSoda()
        {
            bool condition = true;

            Console.WriteLine("Please type your soda selection, 'root beer', 'cola', or 'oranage soda'");
            string sodaSelection = (Console.ReadLine());
            while (condition)
            {
                switch (sodaSelection)
                {
                    case "root beer":
                        Console.WriteLine();
                        Console.WriteLine("You have chosen rootbeer");
                        condition = false;
                        break;
                    case "cola":
                        Console.WriteLine();
                        Console.WriteLine("You have chosen Cola");
                        condition = false;
                        break;
                    case "orange soda":
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
        public static List<int> PickCoins()
        {
            List<int> chosenCoins = new List<int>();
            for (int i = 0; i <4; i++)
            {
                Console.WriteLine("Please choose which coins you would like to use");
                Console.WriteLine("You may enter up to four coins");
                Console.WriteLine("Please choose '1' for quarter, '2' for dime, '3' for nickle, or '4' for penny");
                //Console.WriteLine("If you are done choosing coins please enter '0'");
                int coins = int.Parse(Console.ReadLine());
                switch (coins)
                {
                    case 1:

                        Console.WriteLine();
                        Console.WriteLine("You have chosen a quarter");
                        chosenCoins.Add(1);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("You have chosen a dime");
                        chosenCoins.Add(2);
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("You have chosen a nickle");
                        chosenCoins.Add(3);
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("You have chosen a penny");
                        chosenCoins.Add(4);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("You have chosen to not enter more coins");
                        break;
                }

            }
            return chosenCoins;


        }
    }
}
