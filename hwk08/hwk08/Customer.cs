using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    [Serializable]
    public class Customer
    {
        public string Name { get; set; }

        public  Customer(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "客户名称:" + Name + "\n";
        }
    }
}
