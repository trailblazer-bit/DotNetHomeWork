using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hwk10
{
    public partial class Form1 : Form
    {

        BindingSource crawlResult = new BindingSource();
        Crawler crawler = new Crawler();
        Task[] tasks = new Task[3];   //并行爬取的任务

        public Form1()
        {
            InitializeComponent();
            dgvCrawlURLInfo.DataSource = crawlResult;
            crawler.PageDownloaded += Crawler_PageDownloaded;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
        }

        private void Crawler_CrawlerStopped(Crawler crawler)
        {
            Action action = () => lblInfo.Text = "爬虫已停止";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Crawler_PageDownloaded(Crawler crawler, string url, string info)
        {
            var pageInfo = new { Index = crawlResult.Count + 1, URL = url, Info = info };
            Action action = () => {crawlResult.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //爬虫开始时，先清空数据源
            crawlResult.Clear();

            crawler.StartURL = this.tbURL.Text;
            crawler.init();
            Match match = Regex.Match(crawler.StartURL, Crawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = host;
            crawler.FileFilter = @"((.html?|.aspx|.jsp|.php)$|^[^.]+$)";

            //new Thread(crawler.Start).Start();

            tasks[0] = new Task(crawler.Start);
            tasks[1] = new Task(crawler.Start);
            tasks[2] = new Task(crawler.Start);
            tasks[0].Start();
            tasks[1].Start();
            tasks[2].Start();
            this.lblInfo.Text = "爬虫启动中.....";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
