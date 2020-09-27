using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // public simulation simulations
            // Run Simulation
            SodaMachine sodamachine = new SodaMachine();
            Customer customer = new Customer();
            Wallet wallet = new Wallet();
           
            sodamachine.CreateChange(.06);
            sodamachine.ReturnChangeToWallet(customer, sodamachine.createdChange);



        }
    }
}
