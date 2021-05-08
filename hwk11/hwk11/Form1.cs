using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using hwk11;
using OrderManageSystem;

namespace hwk08
{
    public partial class Form1 : Form
    {
        private OrderService service = new OrderService();
        private OrderSystemDao dao;
        public Form1()
        {
            InitializeComponent();
            dao = new OrderSystemDao(service);
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            orderBindingSource.DataSource = service.OrderList;
        }

        //选中订单列表中的订单
        private void OrderDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orderDetailsBindingSource.DataSource = orderBindingSource.Current as Order;
            orderDetailsBindingSource.DataMember = "orderDetails";

        }

        //删除订单按钮
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows!=null&& OrderDataGridView.SelectedRows.Count>0)
            {
                int id = Int32.Parse(OrderDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                orderBindingSource.DataSource = null;
                dao.RemoveOrder(id);
                orderBindingSource.DataSource = service.OrderList;
            }

        }

        //查询订单按钮
        private void btn_Query_Click(object sender, EventArgs e)
        {
            if (cb_SearchWay.SelectedItem != null && tb_SearchInfo.Text != "")
            {
                string searchWay = this.cb_SearchWay.SelectedItem.ToString();
                if (searchWay.Contains("客户名"))
                {
                    string customerName = tb_SearchInfo.Text;
                    orderBindingSource.DataSource = dao.QueryOrderByCustomer(customerName);
                }
                if (searchWay.Contains("商品名"))
                {
                    string goodName = tb_SearchInfo.Text;
                    orderBindingSource.DataSource = service.QueryOrderByGoodName(goodName);
                }
                if (searchWay.Contains("订单号"))
                {
                    Regex reg = new Regex("^[0-9]*$");
                    if (reg.IsMatch(tb_SearchInfo.Text))
                    {
                        orderBindingSource.DataSource = dao.QueryOrderById(Int32.Parse(tb_SearchInfo.Text));
                    }
                }
                if (searchWay.Contains("订单总额"))
                {
                    Regex reg = new Regex("^[0-9]*$");
                    if (reg.IsMatch(tb_SearchInfo.Text))
                    {
                        orderBindingSource.DataSource = dao.QueryOrderByTotalPrice(Int32.Parse(tb_SearchInfo.Text));
                    }
                }
            }

        }

        //导入订单
        private void btn_Import_Click(object sender, EventArgs e)
        {
            //service.Import("orders.xml");
            dao.ImportData();
            orderBindingSource.ResetBindings(true);
            orderBindingSource.DataSource = service.OrderList;

            DialogResult result = MessageBox.Show("导入订单成功", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //导出订单
        private void btn_ExportOrder_Click(object sender, EventArgs e)
        {
            //service.Export("orders.xml");

            DialogResult result = MessageBox.Show("导出订单成功", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //修改订单
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Order o = orderBindingSource.Current as Order;
            if(o!=null)
            {
                NewOrderForm newOrderForm = new NewOrderForm(o);
                newOrderForm.ShowDialog();
                if (newOrderForm.DialogResult == DialogResult.OK)
                {
                    dao.ModifyOrder(o.ID,newOrderForm.order);
                }
                newOrderForm.Close();
            }
        }

        //新建订单
        private void btn_Create_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrderForm = new NewOrderForm(new Order());
            newOrderForm.ShowDialog();
            if(newOrderForm.DialogResult==DialogResult.OK)
            {
                dao.AddOrder(newOrderForm.order);
                orderBindingSource.DataSource = null;
                orderBindingSource.DataSource = service.OrderList;
            }
            newOrderForm.Close();
        }
    }
}
