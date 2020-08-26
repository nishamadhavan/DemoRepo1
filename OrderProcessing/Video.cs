using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Video : VirtualOrder,IOrder
    {
        public string Name { get; set; }
        public string OrderID { get; set  ; }
        public int quantity { get ; set ; }
        public float price { get ; set ; }

        public void FetchOrders()
        {
            this.Name = "Video";
            this.OrderID = "V1";
            this.price = 100;
            this.quantity =1;
        }
       

        public string ProcessOrders()
        {
            FetchOrders();
            PrintOrders(this);
            return "For the Video Learning to Ski we have added another video First Aid in the packing slip";
        }
    }
}
