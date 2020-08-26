using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public interface IOrder
    {
         string Name { get; set; }
        string OrderID { get; set; }
         int quantity { get; set; }
         float price { get; set; }
        string ProcessOrders();
        void PrintOrders();
        void FetchOrders();
    }
}
