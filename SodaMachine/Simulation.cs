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
        
        public List<double> moneyPassedIn;

        //constructor
        public Simulation()
        {
            customer = new Customer();
            sodamachine = new SodaMachine();
            moneyPassedIn = new List<double>();
        }
        //member methods
        // need to create method to total coins return to variable
        // break down into series of methods and call them to create this
        // return list of coins for change and check if equal value to what cost is. 
        // ie, if change returned = soda cost then no soda given
        // more in simulation class. attempt to simulate it as close to real as possible.
        // ie, same soda passed between backpack and soda machine inventory.
        public void RunSimulation()
        {
            UserInterface.WelcomeMessage();
            customer.ChooseSoda();
            customer.wallet.SelectCoins();
            AttemptToPurchase();
            UserInterface.ThankYou(); 
        }
        public void AttemptToPurchase()
        {
            sodamachine.CheckInventory(sodamachine.can);
            ComparesChange();

        }
       
        public void ComparesChange()
        {
            if (customer.totalCoins >= sodamachine.can.Cost)
            {
                double change = customer.totalCoins - sodamachine.can.Cost;
                if (change == 0)
                {
                    sodamachine.VendSoda();
                    // add cost of the soda to the register list
                }
                else if ( change > 0)
                {
                    //return change to wallet
                    sodamachine.VendSoda();
                    // add cost of soda to register list
                }
                else
                {
                    //return change to wallet 
                    UserInterface.InsufficientFunds();
                }

            }
            //public Can ChooseSelectedSoda(customer.sodaSelection)
            //{
            //    //here will take number from customer.sodaselection and change it to selected soda.
            //    return Can;
            //}  *syntax??????***

        }
        
       


    }
}
