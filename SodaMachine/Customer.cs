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
        //public int sodaSelection;
        

        //constructor
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();

            
        }

        //member methods

        //public void SelectPayment()
        //{
        //    UserInterface.PickCoins();
            
        //}
       
        
        


    }
}
