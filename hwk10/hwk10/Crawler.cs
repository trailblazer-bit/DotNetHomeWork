using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hwk10
{
    class Crawler
    {
        public event Action<Crawler> CrawlerStopped;
        public event Action<Crawler, string, string> PageDownloaded;
        //待下载队列
        Queue<string> pending = new Queue<string>();
        //已下载网页
        public ConcurrentDictionary<string, bool> DownloadedPages { get; } = new ConcurrentDictionary<string, bool>();
        //URL检测表达式，用于在HTML文本中查找URL
        public static readonly string UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        //主机过滤规则
        public string HostFilter { get; set; }
        //文件过滤规则
        public string FileFilter { get; set; }
        //最大下载数量
        public int MaxPage { get; set; }
        //起始网址
        public string StartURL { get; set; }

        //并行爬取的任务数量
        //public int NumOfTask { get; set; }

        public Encoding HtmlEncoding { get; set; }

        public Crawler()
        {
            MaxPage = 10;
            HtmlEncoding = Encoding.UTF8;
        }

        public void init()
        {
            DownloadedPages.Clear();
            pending.Clear();
            pending.Enqueue(StartURL);
        }
        public void Start()
        {
            while (DownloadedPages.Count < MaxPage)
            {
                string url=null;
                lock(this)
                {
                    if(pending.Count>0)
                        url = pending.Dequeue();
                }
                if(url!=null)
                    Crawl(url);
            }
            CrawlerStopped(this);
        }

        //爬取指定的url，并将与其链接的相关url加入到队列中
        private void Crawl(string url)
        {
            try
            {
                string html = DownLoad(url); // 下载
                DownloadedPages[url] = true;
                lock(this)
                {
                    PageDownloaded(this, url, "success");
                }
                Parse(html, url);//解析,并加入新的链接
            }
            catch (Exception ex)
            {
                lock(this)
                {
                    PageDownloaded(this, url, "  Error:" + ex.Message);
                }
            }
        }

        private string DownLoad(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            string fileName = DownloadedPages.Count.ToString();
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
        }

        private void Parse(string html, string pageUrl)
        {
            
            var matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;

                linkUrl = FixUrl(linkUrl, pageUrl);//相对路径转绝对路径

                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;

                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter) &&
                    !DownloadedPages.ContainsKey(linkUrl))
                {
                    lock(this)
                    {
                        pending.Enqueue(linkUrl);
                    }
                }
            }        
        }

        //将相对路径转为绝对路径
        static private string FixUrl(string url, string pageUrl)
        {
            Uri uri = new Uri(new Uri(pageUrl), url);
            return uri.ToString();
        }

    }
}
