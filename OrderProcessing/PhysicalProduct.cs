using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    class PhysicalProduct : IOrder,ICommission
    {
        public string Name { get ; set; }
        public string OrderID { get ; set; }
        public int quantity { get; set; }
        public float price { get ; set ; }

        public void FetchOrders()
        {
            this.Name = "Physical product";
            this.OrderID = "P1";
            this.price = 5000;
            this.quantity = 3;

        }

        public float GetCommission()
        {
            return this.price * 5 / 100;
            
        }

        public void PrintOrders()
        {
            FetchOrders();
            Console.WriteLine("This order is for {0} the order Id is {1} , price is {2}, quantity is {3}", this.Name,this.OrderID,this.price,this.quantity);
        }

        public string ProcessOrders()
        {
            float com = GetCommission();
            PrintOrders();
            return "Created order for the above physical product and calculated commission as "+com;
        }
    }
}
