using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    class OrdersMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABC Order Processing App");
            Console.WriteLine("A. Physical Product");
            Console.WriteLine("B. Book");
            Console.WriteLine("c. Membership");
            Console.WriteLine("D. Upgrade");
            Console.WriteLine("E. Video");
            Console.WriteLine("Provide your selection");
            string selection = Console.ReadLine();
            OrderFactory orderFactory = new OrderFactory();
            IOrder yourSelection = orderFactory.CreateOrderFactoryObjects(selection);
            string orderInfo=yourSelection.ProcessOrders();
            Console.WriteLine(orderInfo);
            Console.ReadLine();
        }
    }
}
