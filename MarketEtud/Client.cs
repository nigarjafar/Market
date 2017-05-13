using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEtud
{
    class Client
    {
        public string Name { get; set; }
        public readonly Dictionary<Product, int> ShoppingBasket = new Dictionary<Product, int>();
       
        public Card card;

        public Client(string name)
        {
            this.Name = name;
        }

        public void AddBasket(Product product, int number)
        {
            if ( ShoppingBasket.ContainsKey(product))
            {
                ShoppingBasket[product] += number;
            }
            else
            {
                ShoppingBasket.Add(product, number);
            }
            product.LeftInStock -= number;

        }

        public void StartShopping()
        {
            while (true)
            {
                Console.WriteLine("Enter product barcode: \n To stop shopping, write stop \n To see product list,enter list");
                string input = Console.ReadLine();
                if (input == "stop")
                    break;
                else if (input == "list")
                    Stock.ShowProducts();
                else
                {
                    int barcode = Convert.ToInt32(input);

                    bool existProduct = Stock.Products.Exists(prod => prod.Barcode == barcode);

                    if (existProduct)
                    {
                        Console.WriteLine("How many items do you want?");
                        int number = Convert.ToInt32(Console.ReadLine());

                        Product product = Stock.Products.Find(prod => prod.Barcode == barcode);

                        if (number > product.LeftInStock)
                        {
                            Console.WriteLine(number + " items do not exist");
                        }
                        else
                        {
                            AddBasket(product, number);

                        }

                    }
                    else
                    {
                        Console.WriteLine("This product does not exist");
                    }
                }
            }


        }

      

        public void AddCard(Card card)
        {
            this.card = card;
        }




    }
}
