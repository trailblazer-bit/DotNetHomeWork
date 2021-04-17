using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManageSystem;

namespace hwk08
{
    public partial class NewOrderForm : Form
    {
        //修改订单或创建订单时用于在两个窗口间传递数据
        public Order order { get; set; }
        public NewOrderForm(Order o)
        {
            InitializeComponent();
            order = o;
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            this.OrderIDTextBox.DataBindings.Add("Text", order, "ID");
            this.CustomerNameTextBox.DataBindings.Add("Text", order, "CustomerName");
            orderDetailBindingSource.DataSource = order;
            orderDetailBindingSource.DataMember = "orderDetails";
        }

        //按下取消按钮
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        //按下确认按钮，提交订单
        private void btn_OK_Click(object sender, EventArgs e)
        {
            order.OrderTime = System.DateTime.Now;
            this.DialogResult = DialogResult.OK;
        }
    }
}
