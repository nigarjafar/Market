using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEtud
{
    class CashMachine
    {
        public static void CalculateCash(Client client)
        {
            double sum = 0;
            foreach(KeyValuePair<Product,int> item in client.ShoppingBasket )
            {
                var product = item.Key;
                var number = item.Value;
                sum += product.Price * number;
            }

            Console.WriteLine("Item subtotal:" + sum);

            if (!client.card.Equals(null))
            {
                sum -= sum * client.card.SalePercentage / 100;
                Console.WriteLine("Item subtotal after sale :" + sum);
            }
           
        }

        public static void PrintCash(Client client)
        {
            Console.WriteLine(String.Format("{0,-30} {1,-30}{2 ,-30} \n\n", "Name", "Number", "Price"));
            foreach (KeyValuePair<Product, int> entry in client.ShoppingBasket)
            {

                Console.WriteLine(String.Format("{0,-30} {1,-30} {2,-30} ", entry.Key.Name, entry.Value, entry.Value*entry.Key.Price));
            }

        }
    }
}
