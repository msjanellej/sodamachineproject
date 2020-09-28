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
        public void RunSimulation()
        {
            UserInterface.WelcomeMessage();           
            sodaMachine.VendSoda(customer);
            UserInterface.ThankYou();
        }
    }
}
