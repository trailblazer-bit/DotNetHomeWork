using System;
using System.Collections.Generic;

namespace OrderManageSystem
{
    class Program
    {
        //创建订单服务实例
        static OrderService service = new OrderService();
        static void Main(string[] args)
        {

            bool _continue = true;
            while(_continue)
            {
                Console.WriteLine("\n\n订单服务开启,输入1添加订单,输入2删除订单,输入3修改订单," +
                    "输入4查询订单,输入0退出订单服务");
                try
                {
                    int op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 0: { _continue = false; break; }
                        case 1:AddOrder();break;
                        case 2:DeleteOrder();break;
                        case 3:ModifyOrder();break;
                        case 4:SearchOrder();break;
                        default: Console.WriteLine("输入的数字,不能获取服务"); break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        public static void AddOrder()
        {
            Console.WriteLine("请输入订单号:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入客户名:");
            string customerName = Console.ReadLine();
            DateTime orderTime = System.DateTime.Now;
            Order order = new Order(id, customerName, orderTime);

            //保证订单不重复
            Order o = service.QueryOrderById(order.ID);
            if (o != null)
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
                    InputOrderDetail(out orderDetail);
                    //保证订单明细不重复
                    if (order.OrderDetails.Contains(orderDetail))
                    {
                        Console.WriteLine("输入的订单明细有重复,重新输入!");
                    }
                    else
                        order.OrderDetails.Add(orderDetail);

                    //继续添加订单明细
                    Console.WriteLine("是否继续输入(请输入Y/N)");
                    char ch = Console.ReadLine()[0];
                    if (ch == 'Y')
                        continue;
                    else if (ch == 'N')
                        break;
                    else Console.WriteLine("输入错误!");
                }
                Console.WriteLine();
            }
            service.AddOrder(order);
            
        }
        public static void DeleteOrder()
        {
            Console.WriteLine("请输入要删除的订单号:");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                service.RemoveOrder(id);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //根据id修改订单
        public static void ModifyOrder()
        {
            Console.WriteLine("请输入要修改的订单号:");
            int id;
            try
            {
                id = Convert.ToInt32(Console.ReadLine());

                Order o = service.QueryOrderById(id);
                if (o == null)
                {
                    Console.WriteLine("要修改的订单不存在!");
                    return;
                }
                service.RemoveOrder(id);
                AddOrder();
            }
            catch(Exception e)
            {
                Console.WriteLine("输入错误!");
                return;
            }
        }

        public static void SearchOrder()
        {
            service.ShowOrder();
            Console.WriteLine("按照条件查询订单,输入相应参数");
            Console.WriteLine("按照订单号查询(输入1)");
            Console.WriteLine("按照商品名称查询(输入2)");
            Console.WriteLine("按照客户名称查询(输入3)");
            Console.WriteLine("按照订单金额查询(输入4)");
            try
            {
                int type = Convert.ToInt32(Console.ReadLine());
                List<Order> orders = new List<Order>();
                switch (type)
                {
                    case 1:SearchByID();break;
                    case 2:SearchByGoodName();break;           
                    case 3:SearchByCustomerName();break;
                    case 4:SearchByTotalPrice();break;                   
                    default: Console.WriteLine("没有该查询功能!"); break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("输入参数错误!");
            }
        }

        public static void SearchByID()
        {
            Console.WriteLine("请输入要查询的订单号:");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                Order o=service.QueryOrderById(id);
                if(o==null)
                    Console.WriteLine("查询不到任何订单!");
                else
                    Console.WriteLine(o);
            }
            catch(Exception e)
            {
                Console.WriteLine("输入错误!");
                return;
            }
        }
        public static void SearchByGoodName()
        {
            Console.WriteLine("请输入要查询的商品名称:");
            string goodName = Console.ReadLine();
            List<Order> orders = service.QueryOrderByGoodName(goodName);
            if(orders.Count==0)
            {
                Console.WriteLine("查询不到任何订单!");
                return;
            }
            PrintResultType(orders);
            
        }
        public static void SearchByCustomerName()
        {
            Console.WriteLine("请输入要查询的客户名称:");
            string customerName = Console.ReadLine();
            List<Order> orders = service.QueryOrderByCustomer(customerName);
            if (orders.Count == 0)
            {
                Console.WriteLine("查询不到任何订单!");
                return;
            }
            PrintResultType(orders);
        }
        public static void SearchByTotalPrice()
        {
            Console.WriteLine("请输入要查询的订单金额:");
            double totalPrice = Convert.ToDouble(Console.ReadLine());
            List<Order> orders = service.QueryOrderByTotalPrice(totalPrice);
            if (orders.Count == 0)
            {
                Console.WriteLine("查询不到任何订单!");
                return;
            }
            PrintResultType(orders);
        }


        //用户输入订单明细
        public static void InputOrderDetail(out OrderDetail orderDetail)
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
        public static void PrintResultType(List<Order> orders)
        {
            //先将结果集按总金额排序
            orders.Sort((o1, o2) => o1.TotalPrice.CompareTo(o2.TotalPrice));
            //遍历结果集
            Console.WriteLine("\n\n查询到的订单:");
            foreach (Order order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
