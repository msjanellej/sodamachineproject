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
        public double totalCoins;

        //constructor
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
            
        }

        //member methods
     
        public void ChooseCoins()
        {
            // here I will write the logic for the customer to be able to choose which coins they would like to select
            // remove coins from wallet.
        }
        public void TotalsCoins()
        {
            //totalCoins = Selected coins added together.

        }
    }
}
