using System;

namespace OrderManageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建订单服务实例
            OrderService orderService = new OrderService();
            bool _continue = true;
            while(_continue)
            {
                Console.WriteLine("订单服务开启,输入1添加订单,输入2删除订单,输入3修改订单," +
                    "输入4查询订单,输入5显示所有订单,输入6将订单排序,输入0退出订单服务");
                try
                {
                    int op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 0: { _continue = false; break; }
                        case 1:
                            {
                                orderService.AddOrder();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("请输入要删除的订单号:");
                                int id= Convert.ToInt32(Console.ReadLine());
                                orderService.RemoveOrder(id);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("请输入要修改的订单号:");
                                int id = Convert.ToInt32(Console.ReadLine());
                                orderService.ModifyOrder(id);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("按照条件查询订单,输入相应参数");
                                Console.WriteLine("按照订单号(输入1),按商品名称(输入2),按客户(输入3),按订单金额(输入4)");
                                int type= Convert.ToInt32(Console.ReadLine());
                                orderService.QueryOrder(type);
                                break;
                            }
                        case 5:
                            {
                                orderService.ShowOrder();
                                break;
                            }
                        case 6:
                            {
                                orderService.SortById();
                                break;
                            }
                        default: Console.WriteLine("输入的数字,不能获取服务"); break;
                    }
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
