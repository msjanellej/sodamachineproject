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
        public SodaMachine sodaMachine;
        public Customer customer;

        

        //constructor
        public Simulation()
        {
            customer = new Customer();
            sodaMachine = new SodaMachine();
            
        }
        //member methods

        // more in simulation class. attempt to simulate it as close to real as possible.
        // ie, same soda passed between backpack and soda machine inventory.
        public void RunSimulation()
        {
            UserInterface.WelcomeMessage();
            
            //sodaMachine.VendSoda(,,customer);
            UserInterface.ThankYou();
        }











    }
}
