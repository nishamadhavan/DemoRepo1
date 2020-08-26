using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing;

namespace OrderProcessingTestProject
{
    [TestClass]
    public class OrderFactoryTest
    {
        [TestMethod]
        public void CreateOrderFactoryObjectsTestPhysicalProd()
        {
            OrderFactory expectedFactObj = new OrderFactory();
            string selection = "A";
            IOrder ExpectedResult = expectedFactObj.CreateOrderFactoryObjects(selection);
            Assert.IsInstanceOfType(ExpectedResult, typeof(PhysicalProduct));
;        }
        [TestMethod]
        public void CreateOrderFactoryObjectsTestBook()
        {
            OrderFactory expectedFactObj = new OrderFactory();
            string selection = "B";
            IOrder ExpectedResult = expectedFactObj.CreateOrderFactoryObjects(selection);
            Assert.IsInstanceOfType(ExpectedResult, typeof(Book));
            
        }      
        [TestMethod]
        public void CreateOrderFactoryObjectsTestMembership()
        {
            OrderFactory expectedFactObj = new OrderFactory();
            string selection = "C";
            IOrder ExpectedResult = expectedFactObj.CreateOrderFactoryObjects(selection);
            Assert.IsInstanceOfType(ExpectedResult, typeof(Membership));
            ;
        }
        [TestMethod]
        public void CreateOrderFactoryObjectsTestUpgrade()
        {
            OrderFactory expectedFactObj = new OrderFactory();
            string selection = "D";
            IOrder ExpectedResult = expectedFactObj.CreateOrderFactoryObjects(selection);
            Assert.IsInstanceOfType(ExpectedResult, typeof(Upgrade));
            
        }
        [TestMethod]
        public void CreateOrderFactoryObjectsTestVideo()
        {
            OrderFactory expectedFactObj = new OrderFactory();
            string selection = "E";
            IOrder ExpectedResult = expectedFactObj.CreateOrderFactoryObjects(selection);
            Assert.IsInstanceOfType(ExpectedResult, typeof(Video));

        }
    }
}
