using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
   public class OrderFactory
    {
        public IOrder CreateOrderFactoryObjects(string selection)
        {
            IOrder yourSelection = null;
            switch(selection)
            {
                case "A": yourSelection = new PhysicalProduct();
                    break;
                case "B":
                    yourSelection = new Book();
                    break;
                case "C":
                    yourSelection = new Membership();
                    break;
                case "D":
                    yourSelection = new Upgrade();
                    break;
                case "E":
                    yourSelection = new Video();
                    break;

            }
            return yourSelection;
        }
    }
}
