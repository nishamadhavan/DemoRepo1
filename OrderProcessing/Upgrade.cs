using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Upgrade : VirtualOrder,IOrder, IEmail
    {
        public string Name { get; set; }
        public string OrderID { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public void FetchOrders()
        {
            this.Name = "Upgrade";
            this.OrderID = "U1";
            this.price = 100;
            this.quantity = 1;
        }

      

        public string ProcessOrders()
        {
            FetchOrders();
            PrintOrders(this);
            return "Membership is upgraded and " + SendMail("Peter@contonso.com", "Courteny@abc.com");
        }

        public string SendMail(string From, string To)
        {
            return ("Email is sent to " + To + "From " + From);
        }
    }
}
