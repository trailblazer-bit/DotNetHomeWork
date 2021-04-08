using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderManageSystem;
using System;
using System.IO;

namespace hwk06Test
{
    [TestClass]
    public class OderSystemTest
    {
        List<Order> orders = new List<Order>();

        [TestInitialize]
        public void Init()
        {
            Good good1 = new Good("篮球", 56);
            Good good2 = new Good("足球", 78);
            Good good3 = new Good("排球", 34);

            Customer customer1 = new Customer("Jack");
            Customer customer2 = new Customer("Nike");

            Order order1 = new Order(1, customer1.Name, System.DateTime.Now);
            Order order2 = new Order(2, customer2.Name, System.DateTime.Now);
            Order order3 = new Order(3, customer2.Name, System.DateTime.Now);

            order1.AddDetail(new OrderDetail(good1, 7));
            order2.AddDetail(new OrderDetail(good1, 7));
            order2.AddDetail(new OrderDetail(good2, 9));
            order3.AddDetail(new OrderDetail(good1, 7));
            order3.AddDetail(new OrderDetail(good2, 9));
            order3.AddDetail(new OrderDetail(good3, 12));

            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestAddOrder()
        {
            OrderService service = new OrderService();

            service.AddOrder(orders[0]);
            service.AddOrder(orders[1]);
            service.AddOrder(orders[2]);
            service.AddOrder(orders[0]);
            CollectionAssert.AreEqual(service.OrderList, orders);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestRemoveOrder()
        {
            OrderService service = new OrderService();
            service.AddOrder(orders[0]);
            service.AddOrder(orders[1]);
            service.AddOrder(orders[2]);
            service.RemoveOrder(orders[2].ID);
            service.RemoveOrder(orders[2].ID);

            orders.Remove(orders[2]);
            CollectionAssert.AreEqual(service.OrderList, orders);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestModifyOrder()
        {
            OrderService service = new OrderService();
            service.AddOrder(orders[0]);
            service.AddOrder(orders[1]);
            service.AddOrder(orders[1]);

            service.ModifyOrder(orders[1].ID, orders[2]);
            orders.Remove(orders[1]);
            CollectionAssert.AreEqual(orders, service.OrderList);
        }

        [TestMethod]
        public void TestQueryOrderById()
        {
            OrderService service = new OrderService();
            service.AddOrder(orders[0]);
            service.AddOrder(orders[1]);
            service.AddOrder(orders[2]);

            Order o = service.QueryOrderById(orders[1].ID);
            Assert.AreEqual(o, orders[1]);
        }


        [TestMethod]
        public void TestQueryOrderByGoodName()
        {
            OrderService service = new OrderService();
            service.AddOrder(orders[0]);
            service.AddOrder(orders[1]);
            service.AddOrder(orders[2]);

            List<Order> os = service.QueryOrderByGoodName("篮球");
            CollectionAssert.AreEqual(os, orders);
        }

        [TestMethod]
        public void TestQueryOrderByCustomer()
        {
            OrderService service = new OrderService();
            service.AddOrder(orders[0]);
            service.AddOrder(orders[1]);
            service.AddOrder(orders[2]);

            List<Order> os = service.QueryOrderByCustomer("Nike");
            orders.Remove(orders[0]);
            CollectionAssert.AreEqual(os, orders);
        }

        [TestMethod]
        public void TestQueryOrderByTotalPrice()
        {
            OrderService service = new OrderService();
            service.AddOrder(orders[0]);
            service.AddOrder(orders[1]);
            service.AddOrder(orders[2]);

            List<Order> os = service.QueryOrderByTotalPrice(orders[0].TotalPrice);
            orders.Remove(orders[2]);
            orders.Remove(orders[1]);
            CollectionAssert.AreEqual(os, orders);
        }
        [TestMethod]

        public void TestSort()
        {
            OrderService service = new OrderService();
            service.AddOrder(orders[2]);
            service.AddOrder(orders[0]);
            service.AddOrder(orders[1]);
            service.Sort();

            CollectionAssert.AreEqual(orders, service.OrderList);

        }

        [TestMethod]
        public void TestShowOrders()
        {
            OrderService service = new OrderService();
            service.AddOrder(orders[0]);
            service.AddOrder(orders[1]);
            service.AddOrder(orders[2]);

            service.ShowOrder();

        }

        [TestMethod]
        public void TestExport()
        {
            OrderService service = new OrderService();
            service.AddOrder(orders[0]);
            service.AddOrder(orders[1]);
            service.AddOrder(orders[2]);

            //判断序列化生成的文件是否存在
            service.Export("testOrders.xml");
            DateTime time = DateTime.Now;
            Assert.IsTrue(File.Exists("testOrders.xml"));

            //判断生成的文件是否是最新的
            FileInfo file = new FileInfo("testOrders.xml");
            Assert.AreEqual(file.LastWriteTime,time);
        }

        [TestMethod]
        public void TestImport()
        {
            OrderService service = new OrderService();
            service.Import("testOrders.xml");
            //是否导入成功
            CollectionAssert.AreEqual(service.OrderList, orders);
        }
    }
}
