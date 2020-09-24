using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //member variables
        public Card creditcard;
        public List<Coin> coins;
        public double selectedCoins;

        //constructor
        public Wallet()
        {
            creditcard = new Card();
            coins = new List<Coin>();
        }

        //member methods
        public double SelectCoins()
        {

            return selectedCoins;
            //need to display the coins in the list.
            // need to allow user input to select coins to use for purchase.
            
        }
    }
}
