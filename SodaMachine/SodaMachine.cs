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
        //public void AttemptToPurchase()
        //{
        //    if (coin.Value == can.Cost) //need to create method to total coins return to variable
        //                                // break down into series of methods and call them to create this
        //                                // return list of coins for change and check if equal value to what cost is. 
        //                                // ie, if change returned = soda cost then no soda given
        //                                // more in simulation class. attempt to simulate it as close to real as possible.
        //                                // ie, same soda passed between backpack and soda machine inventory.
        //    {
        //        if (can == inventory.Contains) <--- make a function to find any can that meets criteria. 
        //        {
        //            //give soda to customer put in backpack list
        //        }
        //        else
        //        {
        //            // give money back to wallet
        //        }
        //    }
        //    else if (coin.Value > can.Cost)
        //    {
        //        if ()
        //        {
        //            // need to say in conditional: If coin.value - cost = register value contains?
        //            // Then Soda to Back pack & Change to Wallet
        //        }
        //        else
        //        {
        //            // return money to wallet.
        //        }
        //    }
        //    else
        //    {
        //        //think this could be an else, maybe needs to be else if not sure
        //        // return money to wallet. 
        //    }
        //}

    }
}
