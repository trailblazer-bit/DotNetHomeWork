
namespace hwk08
{
    partial class NewOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Order = new System.Windows.Forms.TableLayoutPanel();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.OrderIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.OrderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Order
            // 
            this.Order.ColumnCount = 2;
            this.Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Order.Controls.Add(this.OrderIDLabel, 0, 0);
            this.Order.Controls.Add(this.CustomerNameLabel, 0, 1);
            this.Order.Controls.Add(this.OrderIDTextBox, 1, 0);
            this.Order.Controls.Add(this.CustomerNameTextBox, 1, 1);
            this.Order.Controls.Add(this.btn_OK, 0, 2);
            this.Order.Controls.Add(this.btn_Cancel, 1, 2);
            this.Order.Location = new System.Drawing.Point(12, 12);
            this.Order.Name = "Order";
            this.Order.RowCount = 3;
            this.Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.Order.Size = new System.Drawing.Size(266, 185);
            this.Order.TabIndex = 0;
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Location = new System.Drawing.Point(3, 21);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(127, 15);
            this.OrderIDLabel.TabIndex = 0;
            this.OrderIDLabel.Text = "订单号";
            this.OrderIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(3, 79);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(127, 15);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "客户名称";
            this.CustomerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderIDTextBox
            // 
            this.OrderIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderIDTextBox.Location = new System.Drawing.Point(136, 16);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.Size = new System.Drawing.Size(127, 25);
            this.OrderIDTextBox.TabIndex = 2;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerNameTextBox.Location = new System.Drawing.Point(136, 74);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(127, 25);
            this.CustomerNameTextBox.TabIndex = 3;
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(3, 127);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(127, 46);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "确认";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(136, 127);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 46);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // OrderDetailsDataGridView
            // 
            this.OrderDetailsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDetailsDataGridView.AutoGenerateColumns = false;
            this.OrderDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodNameDataGridViewTextBoxColumn,
            this.goodPriceDataGridViewTextBoxColumn,
            this.goodNumDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.OrderDetailsDataGridView.DataSource = this.orderDetailBindingSource;
            this.OrderDetailsDataGridView.Location = new System.Drawing.Point(6, 217);
            this.OrderDetailsDataGridView.Name = "OrderDetailsDataGridView";
            this.OrderDetailsDataGridView.RowHeadersWidth = 51;
            this.OrderDetailsDataGridView.RowTemplate.Height = 27;
            this.OrderDetailsDataGridView.Size = new System.Drawing.Size(722, 224);
            this.OrderDetailsDataGridView.TabIndex = 4;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodPriceDataGridViewTextBoxColumn
            // 
            this.goodPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodPrice";
            this.goodPriceDataGridViewTextBoxColumn.HeaderText = "GoodPrice";
            this.goodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodPriceDataGridViewTextBoxColumn.Name = "goodPriceDataGridViewTextBoxColumn";
            this.goodPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodNumDataGridViewTextBoxColumn
            // 
            this.goodNumDataGridViewTextBoxColumn.DataPropertyName = "GoodNum";
            this.goodNumDataGridViewTextBoxColumn.HeaderText = "GoodNum";
            this.goodNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNumDataGridViewTextBoxColumn.Name = "goodNumDataGridViewTextBoxColumn";
            this.goodNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(OrderManageSystem.OrderDetail);
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 446);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.OrderDetailsDataGridView);
            this.Name = "NewOrderForm";
            this.Text = "NewOrderForm";
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Order;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.TextBox OrderIDTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.DataGridView OrderDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}