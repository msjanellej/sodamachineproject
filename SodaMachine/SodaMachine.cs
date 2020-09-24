using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //member variables
        // public register list<coin>
        public List<Can> inventory;
        
        

        //constructor
        public SodaMachine()
        {
            inventory = new List<Can>();
            
        }


        //member methods
        public void AttemptToPurchase()
        {
            if (coin.value == can.cost)
            {
                if (soda == inventory.Contains)
                {
                    //give soda to customer put in backpack list
                }
                else
                {
                    // give money back to wallet
                }
            }
            else if (coin.value > can.cost)
            {
                if ()
                {
                    // need to say in conditional: If coin.value - cost = register value contains?
                    // Then Soda to Back pack & Change to Wallet
                }
                else
                {
                    // return money to wallet.
                }
            }
            else
            {
                //think this could be an else, maybe needs to be else if not sure
                // return money to wallet. 
            }
        }

    }
}
