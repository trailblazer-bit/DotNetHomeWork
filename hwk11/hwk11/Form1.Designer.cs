
namespace hwk08
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Query = new System.Windows.Forms.Button();
            this.cb_SearchWay = new System.Windows.Forms.ComboBox();
            this.tb_SearchInfo = new System.Windows.Forms.TextBox();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_ExportOrder = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Query
            // 
            this.btn_Query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Query.Location = new System.Drawing.Point(186, 13);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(109, 35);
            this.btn_Query.TabIndex = 4;
            this.btn_Query.Text = "查询订单";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // cb_SearchWay
            // 
            this.cb_SearchWay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_SearchWay.FormattingEnabled = true;
            this.cb_SearchWay.Items.AddRange(new object[] {
            "按订单号查询",
            "按商品名称查询",
            "按客户名称查询",
            "按订单总额查询"});
            this.cb_SearchWay.Location = new System.Drawing.Point(3, 19);
            this.cb_SearchWay.Name = "cb_SearchWay";
            this.cb_SearchWay.Size = new System.Drawing.Size(116, 23);
            this.cb_SearchWay.TabIndex = 7;
            // 
            // tb_SearchInfo
            // 
            this.tb_SearchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SearchInfo.Location = new System.Drawing.Point(125, 18);
            this.tb_SearchInfo.Name = "tb_SearchInfo";
            this.tb_SearchInfo.Size = new System.Drawing.Size(55, 25);
            this.tb_SearchInfo.TabIndex = 9;
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDataGridView.AutoGenerateColumns = false;
            this.OrderDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.OrderDataGridView.DataSource = this.orderBindingSource;
            this.OrderDataGridView.Location = new System.Drawing.Point(2, 116);
            this.OrderDataGridView.MultiSelect = false;
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.ReadOnly = true;
            this.OrderDataGridView.RowHeadersWidth = 51;
            this.OrderDataGridView.RowTemplate.Height = 27;
            this.OrderDataGridView.Size = new System.Drawing.Size(917, 213);
            this.OrderDataGridView.TabIndex = 10;
            this.OrderDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrderDataGridView_CellMouseClick);
            // 
            // OrderDetailsDataGridView
            // 
            this.OrderDetailsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDetailsDataGridView.AutoGenerateColumns = false;
            this.OrderDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodNameDataGridViewTextBoxColumn,
            this.goodPriceDataGridViewTextBoxColumn,
            this.goodNumDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.OrderDetailsDataGridView.DataSource = this.orderDetailsBindingSource;
            this.OrderDetailsDataGridView.Location = new System.Drawing.Point(2, 335);
            this.OrderDetailsDataGridView.MultiSelect = false;
            this.OrderDetailsDataGridView.Name = "OrderDetailsDataGridView";
            this.OrderDetailsDataGridView.ReadOnly = true;
            this.OrderDetailsDataGridView.RowHeadersWidth = 51;
            this.OrderDetailsDataGridView.RowTemplate.Height = 27;
            this.OrderDetailsDataGridView.Size = new System.Drawing.Size(917, 227);
            this.OrderDetailsDataGridView.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.82027F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.17972F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Query, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_SearchInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_SearchWay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Delete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Import, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_ExportOrder, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Update, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Create, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 61);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Location = new System.Drawing.Point(301, 13);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(102, 35);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "删除订单";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Import.Location = new System.Drawing.Point(409, 13);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(108, 35);
            this.btn_Import.TabIndex = 11;
            this.btn_Import.Text = "导入订单";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_ExportOrder
            // 
            this.btn_ExportOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExportOrder.Location = new System.Drawing.Point(523, 13);
            this.btn_ExportOrder.Name = "btn_ExportOrder";
            this.btn_ExportOrder.Size = new System.Drawing.Size(99, 35);
            this.btn_ExportOrder.TabIndex = 12;
            this.btn_ExportOrder.Text = "导出订单";
            this.btn_ExportOrder.UseVisualStyleBackColor = true;
            this.btn_ExportOrder.Click += new System.EventHandler(this.btn_ExportOrder_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Location = new System.Drawing.Point(628, 13);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(101, 35);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "修改订单";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create.Location = new System.Drawing.Point(735, 13);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(155, 35);
            this.btn_Create.TabIndex = 14;
            this.btn_Create.Text = "新建订单";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodPriceDataGridViewTextBoxColumn
            // 
            this.goodPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodPrice";
            this.goodPriceDataGridViewTextBoxColumn.HeaderText = "商品价格";
            this.goodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodPriceDataGridViewTextBoxColumn.Name = "goodPriceDataGridViewTextBoxColumn";
            this.goodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodNumDataGridViewTextBoxColumn
            // 
            this.goodNumDataGridViewTextBoxColumn.DataPropertyName = "GoodNum";
            this.goodNumDataGridViewTextBoxColumn.HeaderText = "商品数量";
            this.goodNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNumDataGridViewTextBoxColumn.Name = "goodNumDataGridViewTextBoxColumn";
            this.goodNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "总额";
            this.totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(OrderManageSystem.OrderDetail);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.Frozen = true;
            this.iDDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "客户名称";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "下单时间";
            this.orderTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "订单金额";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderManageSystem.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.OrderDetailsDataGridView);
            this.Controls.Add(this.OrderDataGridView);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.ComboBox cb_SearchWay;
        private System.Windows.Forms.TextBox tb_SearchInfo;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView OrderDetailsDataGridView;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_ExportOrder;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Create;
    }
}

