using OrderManageSystem;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwk11
{
    class OrderSystemDao
    {
        private OrderService orderService;
        public OrderSystemDao(OrderService orderService)
        {
            this.orderService = orderService;
        }
        //从数据库中导入数据
        public void ImportData()
        {
            using(var db=new OrderSystemContext())
            {
                orderService.OrderList.Clear();
                List<Order> orders = db.DBOrder.ToList<Order>();
                for (int i = 0; i < orders.Count; i++)
                {
                    db.DBOrderDetail.ToList().Where(od => od.OrderId == orders[i].ID).ToList<OrderDetail>();
                    orderService.AddOrder(orders[i]);                   
                }
            }
        }

        //将列表中的数据导出到数据库中
        public void Export()
        {
            using (var db=new OrderSystemContext())
            {
                db.SaveChanges();
            }
        }

        //删除订单
        public void RemoveOrder(int id)
        {
            orderService.RemoveOrder(id);
            using (var db = new OrderSystemContext())
            {
                var order = db.DBOrder.Include("orderDetails").FirstOrDefault(o => o.ID == id);
                db.DBOrder.Remove(order);
                db.SaveChanges();
            }
        }

        //查询订单

        public Order QueryOrderById(int id)
        {
            using (var db = new OrderSystemContext())
            {
                var order = db.DBOrder.Include("orderDetails").FirstOrDefault(o => o.ID == id);
                return order;
            }
        }

        public List<Order> QueryOrderByGoodName(string goodName)
        {
            using (var db = new OrderSystemContext())
            {
                var order = db.DBOrder.Include("orderDetails").ToList().Where
                    (o => o.OrderDetails.Any(detail => detail.GoodName == goodName)).ToList();
                return order;
            }
        }

        public List<Order> QueryOrderByCustomer(string customerName)
        {
            using (var db = new OrderSystemContext())
            {
                var order = db.DBOrder.Include("orderDetails").Where(o => o.CustomerName == customerName).ToList();
                return order;
            }
        }

        public List<Order> QueryOrderByTotalPrice(double price)
        {
            using (var db = new OrderSystemContext())
            {
                var order = db.DBOrder.Include("orderDetails").ToList().Where(o => o.TotalPrice == price).ToList();
                return order;
            }
        }

        //根据id修改订单
        public void ModifyOrder(int id, Order order)
        {           
            using (var db = new OrderSystemContext())
            {
                orderService.RemoveOrder(id);
                orderService.OrderList.Add(order);
                this.RemoveOrder(id);
                this.AddOrder(order);
                db.SaveChanges();
            }
        }

        //添加订单
        public void AddOrder(Order order)
        {
            orderService.OrderList.Add(order);
            using(var db=new OrderSystemContext())
            {
                var customer = db.DBCustomer.FirstOrDefault(c => c.Name == order.CustomerName);
                if(customer==null)
                {
                    db.DBCustomer.Add(new Customer() { Name = order.CustomerName });
                }
                foreach (var detail in order.OrderDetails)
                {
                    var good = new Good(detail.GoodName, detail.GoodPrice);
                    var result = db.DBGood.ToList().FirstOrDefault(g => g.Name==good.Name);
                    if (result == null)
                        db.DBGood.Add(good);
                }

                db.DBOrder.Add(order);
                db.SaveChanges();
            }
        }

    }
}
