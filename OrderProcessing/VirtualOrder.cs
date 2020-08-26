using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class VirtualOrder
    {       
        public virtual void PrintOrders(IOrder order)
        {
           
            Console.WriteLine("This order is for {0} the order Id is {1} , price is {2}, quantity is {3}", order.Name, order.OrderID, order.price, order.quantity);
        }
      
    }
}
