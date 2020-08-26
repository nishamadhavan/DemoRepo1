using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    class Book:IOrder,ICommission
    {
        public string Name { get; set; }
        public string OrderID { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }

        public void FetchOrders()
        {
            this.Name = "Book";
            this.OrderID = "B1";
            this.price = 500;
            this.quantity = 2;

        }

        public float GetCommission()
        {
            return this.price * 2 / 100;

        }

        public void PrintOrders()
        {
            FetchOrders();
            Console.WriteLine("This order is for {0} the order Id is {1} , price is {2}, quantity is {3}", this.Name, this.OrderID, this.price, this.quantity);
        }

        public string ProcessOrders()
        {
            float com = GetCommission();
            PrintOrders();
            return "Created order for the above physical product and calculated commission as " + com;
        }
    }
}
