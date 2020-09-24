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

        public List<double> moneyPassedIn;

        //constructor
        public Simulation()
        {
            customer = new Customer();
            sodamachine = new SodaMachine();
            moneyPassedIn = new List<double>();
        }
        //member methods
       
        // more in simulation class. attempt to simulate it as close to real as possible.
        // ie, same soda passed between backpack and soda machine inventory.
        public void RunSimulation()
        {
            UserInterface.WelcomeMessage();
            //ChooseSelectedSoda();
            customer.wallet.SelectCoins();
            AttemptToPurchase();
            UserInterface.ThankYou();
        }
        public void AttemptToPurchase()
        {
            sodamachine.CheckInventory(sodamachine.can); //how would I reference this.
            ComparesChange();
        }
        public void ComparesChange()
        {
            if (moneyPassedIn >= sodamachine.can.Cost)
            {
                double change = customer.totalCoins - sodamachine.can.Cost;

                sodamachine.VendSoda();
                AddPaymentToRegister();
                RemoveSodaFromInventory();
                AddSodaToBackpack();
                RemovePaymentfromWallet();
                AddSodaToBackpack();
                if (change > 0)
                {
                    ReturnChangeToWallet();
                }
            }
            else
            {
                ReturnChangeToWallet();
                UserInterface.InsufficientFunds();
            }
        }
        public Can ChooseSelectedSoda(customer.sodaSelection) // same issue as above..
        {
            //here will take number from customer.sodaselection and change it to selected soda.
            string can = customer.sodaSelection.ToString();
            return can; //how do i get it to return the selected can from the soda selection class.
        }
        public void ReturnChangeToWallet()
        {

        }
        public void RemoveSodaFromInventory()
        {
            // is this housed here or on sodamachine??
        }
        public void RemovePaymentfromWallet()
        {

        }
        public void AddSodaToBackpack()
        {

        }
        public void AddPaymentToRegister()
        {

        } 



    }
}
