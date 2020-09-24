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
        public SodaMachine sodamachine;
        public Customer customer;
        public double totalCoins;
        public List<double> moneyPassedIn;

        //constructor
        public Simulation()
        {
            customer = new Customer();
            sodamachine = new SodaMachine();
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
        public void RunSimulation()
        {
            UserInterface.WelcomeMessage();
            sodamachine.ChooseSoda();
            customer.wallet.SelectCoins();
            AttemptToPurchase();
            UserInterface.ThankYou(); 
        }
        public void AttemptToPurchase()
        {
            sodamachine.CheckInventory(customer.sodaSelection);
            ComparesChange();

        }
        public void TotalsCoins()
        {
            //totalCoins = Selected coins added together.
            
        }
        public void ComparesChange()
        {
            if (totalCoins >= sodamachine.Cost)
            {
                double change = totalCoins - sodamachine.Cost;
                if (change == 0)
                {
                    VendSoda();
                }
                else if ( change > 0)
                {
                    //return change to wallet
                    VendSoda();
                }
                else
                {
                    //return change to wallet 
                    UserInterface.InsufficientFunds();
                }

            }
            
        }
        
        public void VendSoda()
        {
            // will remove soda from inventory and add to the backpack.
        }


    }
}
