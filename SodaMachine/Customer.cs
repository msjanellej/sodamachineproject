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
            // and put into a new list. Return list.

            
        }
        // write static method (perhaps own class) that takes in the items from the list and returns value. this method
        // can be used on the soda machine as well. Maybe math class. 
        

    }
}
