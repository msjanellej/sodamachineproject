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
        public List<Coin> register;
        public List<Can> inventory;
        //constructor
        public SodaMachine()
        {
            inventory = new List<Can>();
            register = new List<Coin>();
            FillInventory();
            FillRegister();
        }
        //member methods
        public void FillInventory()
        {
            for (int i = 0; i < 3; i++)
            {
                RootBeer rootbeer = new RootBeer();
                inventory.Add(rootbeer);
            }
            for (int i = 0; i < 3; i++)
            {
                Cola cola = new Cola();
                inventory.Add(cola);
            }
            for (int i = 0; i < 3; i++)
            {
                OrangeSoda orangeSoda = new OrangeSoda();
                inventory.Add(orangeSoda);
            }
        }
        public void FillRegister()
        {
            Quarter quarter = new Quarter();
            Dime dime = new Dime();
            Nickle nickle = new Nickle();
            Penny penny = new Penny();
            for (int i = 0; i < 20; i++)
            {
                quarter = new Quarter();
                register.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                dime = new Dime();
                register.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                nickle = new Nickle();
                register.Add(nickle);
            }
            for (int i = 0; i < 50; i++)
            {
                penny = new Penny();
                register.Add(penny);
            }
        }
        public Can CheckInventory(string soda)
        {
            Can can = FindSodaOnList(soda);
            if (soda == null)
            {
                UserInterface.NoInventoryAvailable();
                
            }
            else
            {
                return can;
            }
            return null;
        }
        public void VendSoda(string sodaChoice,Customer customer)
        {
            FindSodaOnList(UserInterface.ChooseSoda());
            Can chosenSoda = CheckInventory(sodaChoice);
            double coinValue = customer.PaymentProcess();
            double change = Math.DetermineChange(coinValue, chosenSoda.Cost);
            List<Coin> changeList = new List<Coin>();
            changeList = CreateChange(change);
            if (chosenSoda == null)
            {
                ReturnChangeToWallet(customer, changeList);
            }
            RemoveSodaFromInventory(chosenSoda);
            AddPaymentToRegister(payment);
            ReturnChangeToWallet(customer, changeList);
            AddSodaToBackpack(RemoveSodaFromInventory(chosenSoda), customer);   
        }
        public Can FindSodaOnList(string soda)
        {
            foreach (Can can in inventory)
            {
                if (can.name == soda)
                {
                    return can;
                }

            }
            return null;
        }
        public List<Can> RemoveSodaFromInventory(Can chosenSoda)
        {
            List<Can> sodaSelection = new List<Can>();
            foreach (Can can in inventory)
            {
                if (can.name == chosenSoda.name)
                {
                    inventory.Remove(chosenSoda);
                }
            }
            sodaSelection.Add(chosenSoda);
            return sodaSelection;
        }
        public void AddSodaToBackpack(List<Can> customerSoda, Customer customer)
        {
            customer.backpack.cans.AddRange(customerSoda);
        }
       
       
        public void AddPaymentToRegister(List<Coin> payment)
        {
            register.AddRange(payment);
        }
        public void ReturnChangeToWallet(Customer customer, List<Coin>createdChange)
        {
            
            customer.wallet.coins.AddRange(createdChange);
        }
        public List<Coin> CreateChange(double changeValue)
        {
            double change = changeValue;
            List<Coin> createdChange = new List<Coin>();

            new List<Coin>();
            while (change > 0)
            {
                if (change >= 0.25)
                {
                    change = change - 0.25 + 0.000001;
                    Quarter quarter = new Quarter();
                    createdChange.Add(quarter);
                }
                else if (change >= 0.10)
                {
                    change -= 0.10 + 0.000001;
                    Dime dime = new Dime();
                    createdChange.Add(dime);

                }
                else if (change >= 0.05)
                {
                    change -= 0.05 + 0.000001;
                    Nickle nickle = new Nickle();
                    createdChange.Add(nickle);
                }
                else if (change >= 0.009997999999999993)
                {
                    change -= .01;
                    Penny penny = new Penny();
                    createdChange.Add(penny);
                }
                else
                {
                    break;
                }

            }
            return createdChange;
        }

    }
}


