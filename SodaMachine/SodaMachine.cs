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
        public RootBeer rootbeer;
        public OrangeSoda orangeSoda;
        public Cola cola;
        public Quarter quarter;
        public Dime dime;
        public Nickle nickle;
        public Penny penny;
        
        
        
        

        //constructor
        public SodaMachine()
        { 
            inventory = new List<Can>();
            register = new List<Coin>();
            for (int i=0; i<3; i++)
            {
                rootbeer = new RootBeer();
                inventory.Add(rootbeer);
            }
            for (int i=0; i<3; i++)
            {
                cola = new Cola();
                inventory.Add(cola);
            }
            for (int i = 0; i< 3; i++)
            {
                orangeSoda = new OrangeSoda();
                inventory.Add(orangeSoda);
            }
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

        //member methods
        public void CheckInventory()
        {
            
            //will check list for selected soda
            // VendSoda()
            // else ConsoleWriteLine "unable to vend, not available"
        }
       
        public void VendSoda()
        {
            // will remove soda from inventory and add to the backpack.
        }

    }
}
