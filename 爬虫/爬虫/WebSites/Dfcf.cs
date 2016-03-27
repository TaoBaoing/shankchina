using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.HtmlParser;

namespace 爬虫
{
    public class Dfcf : ParserBase
    {
        protected override void DoParser()
        {
            #region 股东增持

            WriteTxt("股东增持");
            for (int i = 1; i < 7; i++)
            {
                var url = "http://data.eastmoney.com/DataCenter_V3/gdzjc.ashx?pagesize=50&page=" + i + "&js=var%20sesttOHy&param=&sortRule=-1&sortType=BDJZ&tabid=jzc&code=&name=";
                HttpItem item = new HttpItem();
                item.URL = url;
                item.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                item.UserAgent =
                    "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36";
                var html = HHHtmlParser.GetHttpRequestHtml(item);
                html = html.Substring(html.IndexOf("data:[", StringComparison.Ordinal) + 7);

                html = html.Replace("\"]}", "");
                var values = html.Split(new[] { "\",\"" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string value in values)
                {
                    var date = Convert.ToDateTime(value.Split(',')[15]);
                    if (date.AddMonths(1) > DateTime.Today)
                    {
                        WriteTxt(value);
                    }
                }
            }
            #endregion

            #region 股东减持
            WriteTxt("");
            WriteTxt("");
            WriteTxt("股东减持");

            for (int i = 1; i < 7; i++)
            {
                var url = "http://data.eastmoney.com/DataCenter_V3/gdzjc.ashx?pagesize=50&page=" + i + "&js=var%20zKpORfBg&param=&sortRule=-1&sortType=BDJZ&tabid=jjc&code=&name=&rt=48635609";
                HttpItem item = new HttpItem();
                item.URL = url;
                item.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                item.UserAgent =
                    "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36";
                var html = HHHtmlParser.GetHttpRequestHtml(item);
                html = html.Substring(html.IndexOf("data:[", StringComparison.Ordinal) + 7);

                html = html.Replace("\"]}", "");
                var values = html.Split(new[] { "\",\"" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string value in values)
                {
                    var date = Convert.ToDateTime(value.Split(',')[15]);
                    if (date.AddMonths(1) > DateTime.Today)
                    {
                        WriteTxt(value);
                    }
                }
            }
            #endregion
        }
        protected override string WebSiteName
        {
            get { return "东方财富"; }
        }

        protected override string BaseUrl
        {
            get { return "http://data.eastmoney.com/executive/gdzjc.html"; }
        }
    }
}
