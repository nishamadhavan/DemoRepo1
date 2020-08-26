using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
   public class PhysicalProduct : VirtualOrder,IOrder,ICommission
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

            return 5;
        }
       
        public string ProcessOrders()
        {
            float com = GetCommission();
            FetchOrders();
            PrintOrders(this);
            return "Packing slip for shipping is generated and calculated commission as "+com+" %";
        }
    }
}
