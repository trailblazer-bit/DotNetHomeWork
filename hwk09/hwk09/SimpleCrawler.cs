using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace hwk09
{
    public class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private StringBuilder crawlMessage = new StringBuilder(100);
        private string current;
        private string assignedWebSite;

        public String AssignedWebSite
        {
            get => assignedWebSite;
            set => assignedWebSite = value;
        }
        public String CrawlMessage
        {
            get {
                return crawlMessage.ToString();
            }
            set
            {
                crawlMessage = new StringBuilder(value);
            }
        }
        public Hashtable Urls
        {
            get=>urls;
        }

        //爬行
        public  void Crawl()
        {
            while (true)
            {
                current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (current == null || count > 20) break;

                crawlMessage.Append("爬行" + current + "页面!  ");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接
            }
            MessageBox.Show("爬取结束","Info",MessageBoxButtons.OK);
        }

        //返回html文本
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                //写入本地文件
                File.WriteAllText(fileName, html, Encoding.UTF8);
                crawlMessage.Append("[爬行成功]\r\n");
                return html;
            }
            catch (Exception ex)
            {
                crawlMessage.Append("["+ex.Message+"]"+"\r\n");
                return "";
            }
        }

        //解析html文本，获取其中的超链接
        public  void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                            .Trim('"', '\"', '#', '>');

                //将得到的超链接中的相对地址转化为绝对地址
                Uri uri = new Uri(new Uri(current.Substring(0, current.LastIndexOf('/') + 1)), strRef);
                strRef = uri.ToString();

                //只有当爬取的是html/html/aspx/jsp等网页时，才解析并爬取下一级URL             
                if (!(strRef.Contains("htm")|strRef.Contains("html")
                    | strRef.Contains("aspx") | strRef.Contains("jsp"))) continue;

                //只爬取某个指定网站上的网页
                if (!strRef.Contains(assignedWebSite)) continue;

                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
