using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        //member variables
        public Wallet wallet;
        public Backpack backpack;
        public bool condition;
        public int sodaSelection;

        //constructor
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
            condition = true;
            
        }

        //member methods
        public void ChooseSoda() // this appears not able to be here bc I can't do my validation check.

        {
            while (condition)
            {
                sodaSelection = int.Parse(Console.ReadLine());
                switch (sodaSelection)
                {
                    case 1:
                        Console.WriteLine("Select 1 for Cola");
                        condition = false;
                        break;
                    case 2:
                        Console.WriteLine("Select 2 for RootBeer");
                        condition = false;
                        break;
                    case 3:
                        Console.WriteLine("Select 3 for Orange Soda");
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("You have not made a valid selection");
                        condition = true;
                        break;
                }

            }

        }
    }
}
