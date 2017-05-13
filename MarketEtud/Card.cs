using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketEtud
{
    abstract class Card
    {
        public int CardNumber { get; set; }
        public int SalePercentage { get; set; }

        public Card(int cardNumber)
        {
            
            this.CardNumber = cardNumber;
        }
    }

    class GoldCart :Card

    {
        public GoldCart(int cardNumber):base(cardNumber)
        {
           
            SalePercentage = 20;
        }

    }

    class SilverCart : Card

    {
        public SilverCart(int cardNumber) : base(cardNumber)
        {
            SalePercentage = 10;
        }

    }

    class BronzeCart : Card

    {
        public BronzeCart(int cardNumber) : base(cardNumber)
        {
            SalePercentage = 5;
        }

    }


}
