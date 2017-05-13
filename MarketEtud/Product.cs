using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEtud
{
    class Product
    {
        public int Barcode { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int LeftInStock { get; set; }

        public Product(int barcode,string name,int price, int leftInStock)
        {
            this.Barcode = barcode;
            this.Name = name;
            this.Price = price;
            this.LeftInStock = leftInStock;
        }

    }
}
