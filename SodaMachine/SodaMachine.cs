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
            RootBeer rootbeer = new RootBeer();
            Cola cola = new Cola();
            OrangeSoda orangeSoda = new OrangeSoda();
            for (int i = 0; i < 3; i++)
            {
                rootbeer = new RootBeer();
                inventory.Add(rootbeer);
            }
            for (int i = 0; i < 3; i++)
            {
                cola = new Cola();
                inventory.Add(cola);
            }
            for (int i = 0; i < 3; i++)
            {
                orangeSoda = new OrangeSoda();
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
        public void CheckInventory()
        {
            
            //will check list for selected soda
            // VendSoda()
            // else ConsoleWriteLine "unable to vend, not available"
        }
       
        public void VendSoda()
        {
            // will remove soda from inventory and add to the backpack.
            //inventory.RemoveAt(selectedSoda);
            //backpack.Add
        }
        public void FindSodaOnList()
        {
            // search list by comparing names to find one to do the thing with. 
        }

    }
}
