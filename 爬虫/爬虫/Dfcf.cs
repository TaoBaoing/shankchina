using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 爬虫
{
   public  class Dfcf
    {
        //http://data.eastmoney.com/DataCenter_V3/gdzjc.ashx?pagesize=50&page=3&js=var%20diSTAHjb&param=&sortRule=-1&sortType=BDJZ&tabid=jzc&code=&name=

       public void StartParser()
       {
           for (int i = 0; i < 10; i++)
           {
               var url = "http://data.eastmoney.com/DataCenter_V3/gdzjc.ashx?pagesize=50&page=" + i +"&js=var%20diSTAHjb&param=&sortRule=-1&sortType=BDJZ&tabid=jzc&code=&name=";


           }
       }
    }
}
