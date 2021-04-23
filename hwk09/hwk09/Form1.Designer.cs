
namespace hwk09
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
            this.label_URL = new System.Windows.Forms.Label();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.btn_Crawl = new System.Windows.Forms.Button();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.btn_CralMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_assignedWebSite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_URL
            // 
            this.label_URL.AutoSize = true;
            this.label_URL.Location = new System.Drawing.Point(150, 103);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(31, 15);
            this.label_URL.TabIndex = 0;
            this.label_URL.Text = "URL";
            // 
            // textBox_URL
            // 
            this.textBox_URL.Location = new System.Drawing.Point(235, 100);
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(323, 25);
            this.textBox_URL.TabIndex = 1;
            // 
            // btn_Crawl
            // 
            this.btn_Crawl.Location = new System.Drawing.Point(235, 204);
            this.btn_Crawl.Name = "btn_Crawl";
            this.btn_Crawl.Size = new System.Drawing.Size(106, 44);
            this.btn_Crawl.TabIndex = 2;
            this.btn_Crawl.Text = "开始爬取";
            this.btn_Crawl.UseVisualStyleBackColor = true;
            this.btn_Crawl.Click += new System.EventHandler(this.btn_Crawl_Click);
            // 
            // textBox_Message
            // 
            this.textBox_Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Message.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_Message.Location = new System.Drawing.Point(12, 273);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Message.Size = new System.Drawing.Size(744, 236);
            this.textBox_Message.TabIndex = 3;
            // 
            // btn_CralMessage
            // 
            this.btn_CralMessage.Location = new System.Drawing.Point(392, 204);
            this.btn_CralMessage.Name = "btn_CralMessage";
            this.btn_CralMessage.Size = new System.Drawing.Size(152, 44);
            this.btn_CralMessage.TabIndex = 4;
            this.btn_CralMessage.Text = "生成爬取信息";
            this.btn_CralMessage.UseVisualStyleBackColor = true;
            this.btn_CralMessage.Click += new System.EventHandler(this.btn_CralMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "指定网站";
            // 
            // tb_assignedWebSite
            // 
            this.tb_assignedWebSite.Location = new System.Drawing.Point(235, 145);
            this.tb_assignedWebSite.Name = "tb_assignedWebSite";
            this.tb_assignedWebSite.Size = new System.Drawing.Size(323, 25);
            this.tb_assignedWebSite.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.tb_assignedWebSite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CralMessage);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.btn_Crawl);
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.label_URL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_URL;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.Button btn_Crawl;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Button btn_CralMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_assignedWebSite;
    }
}

