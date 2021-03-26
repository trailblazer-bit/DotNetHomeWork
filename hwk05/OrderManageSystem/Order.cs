using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    class Order
    {
        //订单明细集合
        private List<OrderDetail> orderDetails;

        public int ID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails
        {
            get { return this.orderDetails; }
        }

        public Order(int id,string customerName,DateTime orderTime)
        {
            this.ID = id;
            this.CustomerName = customerName;
            this.OrderTime = orderTime;
            orderDetails = new List<OrderDetail>();
        }

        //获取订单的总金额
        public double GetTotalPrice()
        {
            double sum = 0.0;
            foreach (OrderDetail item in orderDetails)
            {
                sum += item.GoodPrice * item.GoodNum;
            }
            return sum;
        }

        //订单号不能相同
        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   ID == order.ID;
        }

        public override string ToString()
        {
            return "订单号" + ID + " 下单客户:" + CustomerName + " 下单时间:" + OrderTime+" 订单总金额:"+GetTotalPrice();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(orderDetails, ID, CustomerName, OrderTime, OrderDetails);
        }
    }
}
