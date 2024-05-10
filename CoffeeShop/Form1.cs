using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        private Order[] orders = new Order[10]; // Assuming you want to store up to 10 orders
        private int currentIndex = 0;
        private Dictionary<string, int> customerOrderCounts = new Dictionary<string, int>(); // Track number of orders per customer

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (currentIndex < orders.Length)
            {
                Order order = new Order(
                    txtEdtName.Text,
                    txtEdtOrderID.Text,
                    int.Parse(txtEdtCntCoffee.Text),
                    int.Parse(txtEdtCntCupCake.Text)
                );
                orders[currentIndex] = order;
                currentIndex++;

                // Check if customer has ordered more than 5 times
                if (customerOrderCounts.ContainsKey(order.CustomerName))
                {
                    customerOrderCounts[order.CustomerName]++;
                }
                else
                {
                    customerOrderCounts[order.CustomerName] = 1;
                }

                // Apply discount if applicable
                double total = order.CalcTotal();
                if (customerOrderCounts[order.CustomerName] > 5)
                {
                    total *= 0.8; // 20% discount
                }

                txtEdtTotal.Text = total.ToString("C2"); // Display total in currency format
            }
            else
            {
                MessageBox.Show("Maximum number of orders reached.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEdtName.Text = "";
            txtEdtOrderID.Text = "";
            txtEdtCntCoffee.Text = "";
            txtEdtCntCupCake.Text = "";
            txtEdtTotal.Text = "";
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            string displayMessage = "Orders:\n\n";
            for (int i = 0; i < currentIndex; i++)
            {
                Order order = orders[i];
                displayMessage += $"Order ID: {order.OrderID}\n";
                displayMessage += $"Customer Name: {order.CustomerName}\n";
                displayMessage += $"Count Coffee: {order.CountCoffee}\n";
                displayMessage += $"Count CupCake: {order.CountCupCake}\n";
                displayMessage += $"Total: {order.CalcTotal().ToString("C2")}\n"; // Display total in currency format
                displayMessage += "-----------------\n";
            }
            MessageBox.Show(displayMessage, "Orders");
        }
    }

    /*public class Order
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
    }*/
}