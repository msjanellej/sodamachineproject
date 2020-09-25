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

        

        //constructor
        public Simulation()
        {
            customer = new Customer();
            sodamachine = new SodaMachine();
            
        }
        //member methods
       
        // more in simulation class. attempt to simulate it as close to real as possible.
        // ie, same soda passed between backpack and soda machine inventory.
        //public void RunSimulation()
        //{
        //    UserInterface.WelcomeMessage();
        //    SodaMachine.ChooseSelectedSoda(UserInterface.sodaSelection);//<--- Why Error
        //    UserInterface.PickCoins();
        //    AttemptToPurchase(); // vend soda
        //    UserInterface.ThankYou();
        //}
        //public void AttemptToPurchase()
        //{
        //    sodamachine.CheckInventory(); //how would I reference this.
        //    ComparesChange();
        //}
 
        
        //public void ReturnChangeToWallet(Customer customer) //needs to pass wallet/customer in order to give them the money.
        //{
        //    UserInterface.change
        //}
       
        
        public void AddSodaToBackpack()
        {
            //don't try to do the same object until it is working. that's a make better. 
        }
        



    }
}
