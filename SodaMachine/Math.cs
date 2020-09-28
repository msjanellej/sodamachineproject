using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    static class Math
    {
       public static double DetermineChange(double payment, double cost)
        {
            
            double change = payment - cost;
            return change;
            
        }
        public static double DetermineValue(List<Coin> coins)
        {
            double totalValue = 0;
            List<Coin> moneyPassedIn = coins;
            foreach (Coin coin in moneyPassedIn)
            {
                if (coin.Value == .25)
                {
                    return .25;
                }
                else if (coin.Value == .10)
                {
                    return .10;
                }
                else if (coin.Value == .05)
                {
                    return .05;
                }
                else if (coin.Value == .01)
                {
                    return .01;
                }
            }
            return totalValue;
        }
    }
}
