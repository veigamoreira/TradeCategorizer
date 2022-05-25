using System;
using System.Collections.Generic;
using System.Globalization;

namespace TradeCategoralize
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
            var date = Convert.ToDateTime(Console.ReadLine());
            var quantity = int.Parse(Console.ReadLine());

            Trade tradeObj  = new Trade();
            List<Trade> listTrade = new List<Trade>();

           
            int quantityAux = 0;
            string[] trade;
            
            while (quantityAux < quantity)
            {
                trade = Console.ReadLine().Split(" ");

                //checking the array 
                if (trade.Length == 3)
                {
                    tradeObj = new Trade() { Value = Convert.ToDouble(trade[0]), ClientSector = trade[1], NextPaymentDate = DateTime.ParseExact(trade[2], "M/d/yyyy", CultureInfo.InvariantCulture) };
                    listTrade.Add(tradeObj);

                    quantityAux++;
                }
            }


            foreach (var item in listTrade)
            {
                Console.WriteLine(tradeObj.ValidateTrade(item, date));
            }
            Console.ReadKey();


            //Question 2 -  proprierty was cread on Itrade Interface, and the only thing to do is made one more if on the ValidateTrade Method
        }
    }
}
