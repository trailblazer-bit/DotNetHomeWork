using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManageSystem
{
    [Table("order_system.good")]
    [Serializable]
    public class Good
    {
        [Key]
        public string Name { get; set; }
        public double Price { get; set; }
        public Good(string name,double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Good()
        {

        }

        public override string ToString()
        {
            return "商品名称:" + Name + " 商品价格:" + Price+"\n";
        }

        public override bool Equals(object obj)
        {
            Good good = obj as Good;
            return good!=null &&
                   Name == good.Name &&
                   Price == good.Price;
        }
    }
}
