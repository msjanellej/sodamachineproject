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
        public void AttemptToPurchase() //move to customer
        {
            sodamachine.CheckInventory(sodamachine.can); //how would I reference this.
            ComparesChange();
        }
        public void ComparesChange() //move to soda machine.
        {
            if (moneyPassedIn >= sodamachine.can.Cost)
            {
                double change = customer.totalCoins - sodamachine.can.Cost;

                sodamachine.VendSoda();
                AddPaymentToRegister();
                RemovePaymentfromWallet();
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
        public string ChooseSelectedSoda(int selection) // same issue as above..
        {
            
            return can; //how do i get it to return the selected can from the soda selection class.
        }
        public void ReturnChangeToWallet() //needs to pass wallet/customer in order to give them the money.
        {

        }
        public void RemoveSodaFromInventory()
        {
            //sodamachine
        }
        public void RemovePaymentfromWallet(Customer customer)
        {

        }
        public void AddSodaToBackpack()
        {
            //don't try to do the same object until it is working. that's a make better. 
        }
        public void AddPaymentToRegister() //sodamachine.
        {

        } 



    }
}
