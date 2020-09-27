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
        public Quarter quarter;
        public Dime dime;
        public Nickle nickle;
        public Penny penny;

        //constructor
        public Wallet()
        {
            creditcard = new Card();
            coins = new List<Coin>();
            FillWallet();
           
        }
        //member methods
        public void FillWallet()
        {
            for (int i = 0; i < 12; i++)
            {
                quarter = new Quarter();
                coins.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                dime = new Dime();
                coins.Add(dime);
            }
            for (int i = 0; i < 10; i++)
            {
                nickle = new Nickle();
                coins.Add(nickle);
            }
            for (int i = 0; i < 10; i++)
            {
                penny = new Penny();
                coins.Add(penny);
            }
        }
    }
}
