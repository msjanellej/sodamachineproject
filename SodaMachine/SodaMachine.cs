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
        public Can can;
        public Coin coin;
        
        

        //constructor
        public SodaMachine()
        {
            can = new Can();
            coin = new Coin();
            inventory = new List<Can>();
            
        }


        //member methods
        public void AttemptToPurchase()
        {
            if (coin.Value == can.Cost)
            {
                if (can == inventory.Contains)
                {
                    //give soda to customer put in backpack list
                }
                else
                {
                    // give money back to wallet
                }
            }
            else if (coin.Value > can.Cost)
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
