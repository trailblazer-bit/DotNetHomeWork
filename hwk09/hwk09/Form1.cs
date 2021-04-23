using System;
using System.Threading;
using System.Windows.Forms;

namespace hwk09
{
    public partial class Form1 : Form{
        private SimpleCrawler myCrawler = new SimpleCrawler();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Crawl_Click(object sender, EventArgs e)
        {
            string startUrl = textBox_URL.Text;
            string assignedSite = tb_assignedWebSite.Text;
            //http://www.cnblogs.com/dstang2000/
            if(!myCrawler.Urls.ContainsKey(startUrl))
                myCrawler.Urls.Add(startUrl, false);//加入初始页面
            if (assignedSite != null)
                myCrawler.AssignedWebSite = assignedSite;
            new Thread(myCrawler.Crawl).Start();
        }

        private void btn_CralMessage_Click(object sender, EventArgs e)
        {
            //爬虫结束后，生成爬取信息
            this.textBox_Message.Text = myCrawler.CrawlMessage.ToString();
        }
    }
}
