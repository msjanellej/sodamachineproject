using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Simulation
    {
        //member variables
        // public soda machine sodamachine
        // public customer customer
        public double totalCoins;
        public List<double> moneyPassedIn;

        //constructor
        public Simulation()
        {
            moneyPassedIn = new List<double>();
        }
        //member methods
        // Run Simulation() < --- create to use on program class
        // need to create method to total coins return to variable
        // break down into series of methods and call them to create this
        // return list of coins for change and check if equal value to what cost is. 
        // ie, if change returned = soda cost then no soda given
        // more in simulation class. attempt to simulate it as close to real as possible.
        // ie, same soda passed between backpack and soda machine inventory.
        public void AttemptToPurchase()
        {
            CheckInventory();
            ComparesChange();

        }
        public void TotalsCoins()
        {
            // pass total coins into list transaction money
            // Add the value of the list indexes together
            //return total totalcoins
        }
        public void ComparesChange()
        {

            // maybe if statement to see if totalcoins >= can.Cost
            // 
            //      nested in first if: if total change and can.cost from it. return to change variable
            //      if change variable >0 return change to wallet.
            //      VendSoda()
            // else no soda purchased. ConsoleWriteLine insufficient funds
        }
        public void CheckInventory()
        {
            // if selected soda = inventory(check list to find any that match)
            // VendSoda()
            // else ConsoleWriteLine "unable to vend, not available"
        }
        public void VendSoda()
        {
            // will remove soda from inventory and add to the backpack.
        }


    }
}
