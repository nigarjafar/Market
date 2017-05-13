using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEtud
{
    class Stock
    {
        public static readonly List<Product> Products = new List<Product>();

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static void ShowProducts()
        {
            Console.WriteLine(String.Format("{0,-30} {1,-30} {2,-30} {3,-30} \n\n", "Barcode", "Name","Price","Left in stock"));
            foreach (Product entry in Products)
            {
                Console.WriteLine(String.Format("{0,-30} {1,-30} {2,-30} {3,-30}", entry.Barcode, entry.Name, entry.Price, entry.LeftInStock));
            }

        }
    }
}
