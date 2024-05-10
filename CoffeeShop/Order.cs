using System;

namespace CoffeeShop
{
    public class Order
    {
        public string CustomerName { get; }
        public string OrderID { get; }
        public int CountCoffee { get; }
        public int CountCupCake { get; }

        private const double CoffeePrice = 10.00;
        private const double CupCakePrice = 20.00;

        public Order(string customerName, string orderID, int countCoffee, int countCupCake)
        {
            CustomerName = customerName;
            OrderID = orderID;
            CountCoffee = countCoffee;
            CountCupCake = countCupCake;
        }

        public double CalcTotal()
        {
            return CountCoffee * CoffeePrice + CountCupCake * CupCakePrice;
        }

        public string Display()
        {
            string cntCof = CountCoffee.ToString();
            string cntCup = CountCupCake.ToString();
            string strDisplay = CustomerName + " " + OrderID + " " + cntCof + " " + cntCup;

            return strDisplay;
        }
    }
}