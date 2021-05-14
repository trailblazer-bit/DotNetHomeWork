using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManageSystem
{
    [Table("orders")]
    [Serializable]
    public class Order : IComparable
    {
        //订单明细集合
        private List<OrderDetail> orderDetails = new List<OrderDetail>();

        [Key]
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderTime { get; set; }

        public Order()
        {


        }


        //获取订单的总金额
        [NotMapped]
        public double TotalPrice {
            get
            {
                double sum = 0.0;
                foreach (OrderDetail item in orderDetails)
                {
                    sum += item.GoodPrice * item.GoodNum;
                }
                return sum;
            }
            set
            {
                TotalPrice = value;
            }
        }

        public List<OrderDetail> OrderDetails
        {
            get { return this.orderDetails; }
            set { this.orderDetails = value; }
        }

        public Order(int id,string customerName,DateTime orderTime)
        {
            this.ID = id;
            this.CustomerName = customerName;
            this.OrderTime = orderTime;
        }


        //订单号不能相同
        public override bool Equals(object obj)
        {
            Order order= obj as Order;
            return order!=null &&
                   ID == order.ID;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("订单号" + ID + " 下单客户:" + CustomerName + " 下单时间:" + OrderTime + " 订单总金额:" + TotalPrice+"\n");
            for (int i = 0; i < OrderDetails.Count; i++)
            {
                str.Append(i + 1 + " " + OrderDetails[i]+"\n");
            }
            str.Append("--------------------");
            return str.ToString();
        }


        public int CompareTo(object obj)
        {
            Order order = obj as Order;
            if (obj == null) return 0;
            else return this.ID.CompareTo(order.ID);
        }
        
        public void AddDetail(OrderDetail detail)
        {
            if (orderDetails.Contains(detail))
                throw new Exception("订单明细重复");
            orderDetails.Add(detail);
        }
    }
}
