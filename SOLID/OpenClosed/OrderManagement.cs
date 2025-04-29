using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    //public enum CardType
    //{
    //    Standard,
    //    Silver,
    //    Gold
    //}

    public abstract class CardType
    {
        public abstract decimal GetDiscounted(decimal price);
      
    }

    public class Standard : CardType
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * .95m;
        }
    }

    public class Silver : CardType
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * .9m;
        }
    }
    public class Gold : CardType
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * .85m;
        }
    }

    public class Premium : CardType
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * .80m;
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public CardType Card {  get; set; }
    }
    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public decimal GetTotalPrice(decimal price)
        {
            //switch (Customer.Card)
            //{
            //    case CardType.Standard:

            //        return price * .95m;
            //    case CardType.Silver:
            //        return price * .90m;
            //    case CardType.Gold:
            //        return price * .85m;

            //    default:
            //        return price;
            //}
            return Customer.Card.GetDiscounted(price);
        }
    }
}
