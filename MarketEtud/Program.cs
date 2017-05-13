using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEtud
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock.AddProduct(new Product(barcode: 1, name: "Lenovo", price: 1500, leftInStock: 30));
            Stock.AddProduct(new Product(barcode: 2, name: "Hp", price: 2500, leftInStock: 20));
            Stock.AddProduct(new Product(barcode: 3, name: "Acer", price: 500, leftInStock: 4));
            Stock.AddProduct(new Product(barcode: 4, name: "Toshiba", price: 5500, leftInStock: 14));
            Stock.AddProduct(new Product(barcode: 5, name: "Dell", price: 2500, leftInStock: 24));
            Stock.AddProduct(new Product(barcode: 6, name: "Mac", price: 1740, leftInStock: 13));
            Stock.AddProduct(new Product(barcode: 7, name: "Alienware", price: 999, leftInStock: 41));
            
            Stock.ShowProducts();

            Client client = new Client("Iso");
            Card card = new SilverCart(11133);
            client.AddCard(card);
            client.StartShopping();
            CashMachine.PrintCash(client);
            CashMachine.CalculateCash(client);



        }
    }
}
