using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Wired
    {
        private static string html;
        private static Uri url;

        // Bu kısımda wired.comdan güncel 5 başlık ve içeriği alıyorum
        public List<string> SeedText()
        {
            List<string> wired = new List<string>();
            wired.Add(VeriAl("https://www.wired.com/", "//*[@id='main-content']/div[1]/div[1]/section/div[2]/div[2]/div[1]/div[2]/div[2]"));
            wired.Add(VeriAl("https://www.wired.com/", "//*[@id='main-content']/div[1]/div[3]/div/div/div[2]/div[2]/div[3]"));
            wired.Add(VeriAl("https://www.wired.com/", "//*[@id='main-content']/div[1]/div[6]/div/div/div[2]/div[2]/div[3]"));
          
            wired.Add(VeriAl("https://www.wired.com/", "//*[@id='main-content']/div[1]/div[10]/div/div/div[2]/div[2]/div[3]"));
            return wired;
        }

        public List<string> SeedTitle()
        {
            List<string> wired = new List<string>();
            wired.Add(VeriAl("https://www.wired.com/", "//*[@id='main-content']/div[1]/div[1]/section/div[2]/div[2]/div[1]/div[2]/a/h2"));
            wired.Add(VeriAl("https://www.wired.com/", "//*[@id='main-content']/div[1]/div[3]/div/div/div[2]/div[2]/a/h3"));
            wired.Add(VeriAl("https://www.wired.com/", "//*[@id='main-content']/div[1]/div[6]/div/div/div[2]/div[2]/a/h3"));
            wired.Add(VeriAl("https://www.wired.com/", "//*[@id='main-content']/div[1]/div[10]/div/div/div[2]/div[2]/a/h3"));
            return wired;
        }

        private string VeriAl(string Url, string Xpath)
        {
            url = new Uri(Url);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            return (doc.DocumentNode.SelectSingleNode(Xpath).InnerHtml);
        }
    }
}