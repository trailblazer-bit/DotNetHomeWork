using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManageSystem
{
    [Table("customer")]
    [Serializable]
    public class Customer
    {
        [Key]
        public string Name { get; set; }

        public  Customer(string name)
        {
            this.Name = name;
        }

        public Customer()
        {

        }

        public override string ToString()
        {
            return "客户名称:" + Name + "\n";
        }
    }
}
