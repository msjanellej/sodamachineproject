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
        public List<double> moneyPassedIn;
        public string soda;
        RootBeer rootbeer;
        Cola cola;
        OrangeSoda orangeSoda;


        //constructor
        public SodaMachine()
        { 
            inventory = new List<Can>();
            register = new List<Coin>();
            FillInventory();
            FillRegister();
            rootbeer = new RootBeer();
            cola = new Cola();
            orangeSoda = new OrangeSoda();
        }

        //member methods
        public void FillInventory()
        {
            

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
            FindSodaOnList(result);
        }
       
        public void VendSoda()
        {
            RemoveSodaFromInventory();
            
            //Customer.backpack.Add <-- how do I reference this??
        }
        public void FindSodaOnList(Can result)
        {
            result = List<Can>.Find(result); //I want to check the list for the soda that is listed in result
                                            // how else would i do this??

        }
        public void RemoveSodaFromInventory()
        {
            //inventory.RemoveAt(selectedSoda);
        }
        public Can ChooseSelectedSoda(int sodaSelection)
        {
            if (sodaSelection == 1)
            {
                return rootbeer;
                
            }
            else if (sodaSelection == 2)  
            {
                
                return cola;
                
                
            }
            else
            {
                
                return orangeSoda;
            }

        }


    }
}
