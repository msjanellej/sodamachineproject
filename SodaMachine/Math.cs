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
            return .5;
        }
        //public static double AddMoneyTogether(double money)
        //{
        //    return 0;
        //}
        //public static void AddCoins(double coin) I don't believe I need this method.
        //{
        //    double previousCoin = 0;

        //    while (coin != 0)
        //    {
        //        for (double i = 0; i > 5; i++)
        //        {
        //            double currentCoin = i;
        //            double totalCoins = currentCoin + previousCoin;
        //            previousCoin = currentCoin;
        //            currentCoin = totalCoins;
        //        }
        //    }
        //}


    }

}
