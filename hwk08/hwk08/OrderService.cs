using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace OrderManageSystem
{
    public class OrderService
    {
        //存储所有用户的订单
        private List<Order> orderList;

        public List<Order> OrderList
        {
            get
            {
                return orderList;
            }
        }

        public OrderService()
        {
            orderList = new List<Order>();
        }
        
        //添加订单
        public void AddOrder(Order order)
        {
            if (orderList.Contains(order))
                throw new Exception("要添加的订单已经存在!");
            orderList.Add(order);

        }
       
        //根据id删除订单
        public void RemoveOrder(int id)
        {
            int index = -1;
            for(int i=0;i<orderList.Count;i++)
            {
                if(orderList[i].ID==id)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
                throw new Exception("要删除的订单不存在");
            orderList.RemoveAt(index);
        }

        //根据id修改订单
        public void ModifyOrder(int id,Order order)
        {
            this.RemoveOrder(id);
            orderList.Add(order);
        }

        //查询订单


        public Order QueryOrderById(int id)
        {
            Order order = orderList.Where(o => o.ID == id).FirstOrDefault();
            return order;
        }

        public List<Order> QueryOrderByGoodName(string goodName)
        {
            var query = orderList.Where(
                o => o.OrderDetails.Any(detail =>detail.GoodName==goodName)
                );
            return query.ToList();
        }

        public List<Order> QueryOrderByCustomer(string customerName)
        {
            var query = orderList.Where(o => o.CustomerName == customerName);
            return query.ToList();
        }

        public List<Order> QueryOrderByTotalPrice(double price)
        {
            var query = orderList.Where(o => o.TotalPrice == price);
            return query.ToList();
        }

        //展示所有订单
        public void ShowOrder()
        {
            Console.WriteLine("\n\n目前已有订单");
            foreach (Order order in orderList)
            {
                Console.WriteLine(order);
            }         
        }

        //默认按照订单号进行排序
        public void Sort()
        {
            orderList.Sort();
        }

        //自定义排序
        public void Sort(IComparer<Order> comparer)
        {
            orderList.Sort(comparer);
        }

        //序列化
        public void Export(String filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, orderList);
            }
        }

        //反序列化
        public void Import(String filePath)
        {
            XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                orderList= xmlSerializer1.Deserialize(fs) as List<Order>;
            }
        }
    }
}
