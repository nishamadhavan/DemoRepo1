using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Membership : VirtualOrder, IOrder, IEmail
    {
        public string Name { get; set; }
        public string OrderID { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public void FetchOrders()
        {
            this.Name = "Membership";
            this.OrderID = "M1";
            this.price = 250;
            this.quantity = 1;
        }      

        public string ProcessOrders()
        {
            FetchOrders();
            PrintOrders(this);
            return "Membership is activated and "+SendMail("Claire@contonso.com","Susan@abc.com") ;
        }

        public string SendMail(string From, string To)
        {
            return("Email is sent to "+ To+ "From "+From);
        }
    }
}
