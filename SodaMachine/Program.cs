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
            sodamachine.CreateChange(.06);

           
        }
    }
}
