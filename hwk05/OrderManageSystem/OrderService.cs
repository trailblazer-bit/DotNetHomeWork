using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManageSystem
{
    class OrderService
    {
        //存储所有用户的订单
        private List<Order> orderList;

        public OrderService()
        {
            orderList = new List<Order>();
        }
        
        //添加订单
        public void AddOrder()
        {
            Console.WriteLine("\n\n添加订单服务");
            try
            {
                Console.WriteLine("请输入订单号:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入客户名:");
                string customerName = Console.ReadLine();
                DateTime orderTime = System.DateTime.Now;
                Order order = new Order(id, customerName, orderTime);
                //保证订单不重复
                bool exsit = false;
                foreach (Order item in orderList)
                {
                    if (item.Equals(order))
                    {
                        exsit = true;
                        break;
                    }
                }
                if (exsit)
                {
                    Console.WriteLine("订单号重复!");
                    return;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine();
                        OrderDetail orderDetail;
                        InputOrderDetail( out orderDetail);
                        //保证订单明细不重复
                        if(order.OrderDetails.Contains(orderDetail))
                        {
                            Console.WriteLine("输入的订单明细有重复,重新输入!");
                        }
                        else
                            order.OrderDetails.Add(orderDetail);

                        //继续添加订单明细
                        Console.WriteLine("是否继续输入(请输入Y/N)");
                        string s = Console.ReadLine();
                        if (s == "Y")
                            continue;
                        else if (s == "N")
                            break;
                        else;
                    }
                    Console.WriteLine();
                }
                orderList.Add(order);
            }
            catch(Exception e)
            {
                Console.WriteLine("输入参数不合法!");
            }
        }
       
        //根据id删除订单
        public void RemoveOrder(int id)
        {
            bool find = false;
            for (int i = 0; i < orderList.Count; i++)
                if (orderList[i].ID == id)
                {
                    orderList.RemoveAt(i);
                    find = true;
                }
            if(!find)
            {
                throw new ArgumentException("要删除的订单号不存在!");
            }
            Console.WriteLine("订单成功删除!");
        }

        //根据id修改订单
        public void ModifyOrder(int id)
        {
            Console.WriteLine("\n\n修改订单服务");
            Order order = null;
            foreach (var item in orderList)
            {
                if(id==item.ID)
                {
                    order = item;
                    break;
                }
            }
            if (order == null)
            {
                Console.WriteLine("要修改的订单不存在!");
                return;
            }
            Console.WriteLine("输入要修改的订单明细序号");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入修改后的订单明细:");
            OrderDetail orderDetail;
            InputOrderDetail(out orderDetail);
            bool exsit = false;
            for (int i = 0; i < order.OrderDetails.Count; i++)
            {
                if (index-1== i)
                {
                    exsit = true;
                    break;
                }
            }
            if(!exsit)
                Console.WriteLine("要修改的订单明细不存在!");
            else
            {
                order.OrderDetails.RemoveAt(index-1);
                order.OrderDetails.Add(orderDetail);
            }
        }

        //查询订单，多种类型的查询方式
        public void QueryOrder(int type)
        {
            Console.WriteLine("\n\n查询订单服务");
            List<Order> orders = new List<Order>();
            switch(type)
            {
                case 1:
                    {
                        Console.WriteLine("请输入要查询的订单号:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        orders = (from o in orderList where o.ID == id select o).ToList();
                        PrintResultType(orders);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("请输入要查询的商品名称:");
                        string  goodName = Console.ReadLine();
                        foreach (var order in orderList)
                        {
                            for (int i = 0; i < order.OrderDetails.Count; i++)
                            {
                                if(order.OrderDetails[i].GoodName==goodName)
                                {
                                    orders.Add(order);
                                    break;
                                }
                            }
                        }
                        PrintResultType(orders);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("请输入要查询的客户名称:");
                        string customerName = Console.ReadLine();
                        orders = (from o in orderList where o.CustomerName==customerName select o).ToList();
                        PrintResultType(orders);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("请输入要查询的订单金额:");
                        double totalPrice = Convert.ToDouble(Console.ReadLine());
                        orders = (from o in orderList where o.GetTotalPrice() == totalPrice select o).ToList();
                        PrintResultType(orders);
                        break;
                    }
                default: Console.WriteLine("没有该查询功能!");break;
            }

        }

        //展示所有订单
        public void ShowOrder()
        {
            Console.WriteLine("\n\n目前已有订单");
            foreach (Order order in orderList)
            {
                Console.WriteLine(order);
                for (int i = 0; i < order.OrderDetails.Count; i++)
                {
                    Console.WriteLine(i+1+" "+order.OrderDetails[i]);
                }
                Console.WriteLine("--------------------");
            }
            
        }

        //按照订单号进行排序
        public void SortById()
        {
            orderList.Sort((o1, o2) => o1.ID - o2.ID);
        }

        //用户输入订单明细
        public void InputOrderDetail(out OrderDetail orderDetail)
        {
            Console.WriteLine("请输入商品名称:");
            string goodName = Console.ReadLine();
            Console.WriteLine("请输入商品价格:");
            double goodPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入商品数量:");
            int goodNum = Convert.ToInt32(Console.ReadLine());
            OrderDetail oDetail = new OrderDetail(new Good(goodName, goodPrice), goodNum);
            orderDetail = oDetail;
        }

        //打印查询结果集
        public void PrintResultType(List<Order> orders)
        {
            //先将结果集按总金额排序
            orders.Sort((o1, o2) =>Convert.ToInt32(o1.GetTotalPrice()>o2.GetTotalPrice()));
            //遍历结果集

            Console.WriteLine("查询到的订单:");
            foreach (Order order in orders)
            {
                Console.WriteLine(order);
                for (int i = 0; i < order.OrderDetails.Count; i++)
                {
                    Console.WriteLine(i + 1 + " " + order.OrderDetails[i]);
                }
                Console.WriteLine("--------------------");
            }
        }
    }
}
