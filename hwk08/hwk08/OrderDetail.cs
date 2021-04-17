using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    [Serializable]
    public class OrderDetail
    {
        public string GoodName { get; set; }
        public double GoodPrice { get; set; }
        public int GoodNum { get; set; }

        public double TotalPrice
        {
            get
            {
                return GoodPrice * GoodNum;
            }
        }
        public OrderDetail()
        {

        }

        //添加依赖，利用对应的商品初始化订单明细
        public OrderDetail(Good good,int goodNum)
        {
            this.GoodName = good.Name;
            this.GoodPrice = good.Price;
            this.GoodNum = goodNum;
        }

        public override string ToString()
        {
            return "商品名称:" + GoodName + " 商品价格:" + GoodPrice + " 商品数量:" + GoodNum+" 合计:"+TotalPrice;
        }

        public override bool Equals(object obj)
        {
            OrderDetail detail = obj as OrderDetail;
            return detail != null &&
                   GoodName == detail.GoodName;
        }
    }
}
