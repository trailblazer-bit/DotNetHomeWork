using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    class Good
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Good(string name,double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return "商品名称:" + Name + " 商品价格:" + Price+"\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Good good &&
                   Name == good.Name &&
                   Price == good.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }
}
