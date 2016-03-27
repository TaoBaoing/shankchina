using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HH.Base;

namespace 爬虫
{
   public abstract  class ParserBase
   {
        protected Config mConfig=HHXml.DeserializeFromXml<Config>("Config.xml");
       
        protected abstract void DoParser();
       public  void Parser()
       {
           if (File.Exists(TxtName))
           {
                File.Delete(TxtName);
           }
           DoParser();
           AfterParser();
       }

       protected virtual void AfterParser()
       {
           MessageBox.Show("抓取 " + WebSiteName + " 成功");
       }

       protected abstract string WebSiteName { get; }
        protected abstract string BaseUrl { get; }
        protected abstract ConfigWeb ConfigWeb { get; }

        protected string TxtName {
            get { return Path.Combine(mConfig.SaveFilePath, ConfigWeb.TxtName); }
        }
       protected void WriteTxt(string value)
       {
            using (var sw = new StreamWriter(TxtName,true))
            {
                sw.WriteLine(value);
            }
        }
   }
}
