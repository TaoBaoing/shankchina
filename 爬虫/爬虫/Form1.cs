using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.Base;

namespace 爬虫
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //            var co=new Config();
            //            co.SaveFilePath = "D:\\";
            //            co.ConfigWebs.Add(new ConfigWeb() {WebNamel = "东方财富",WebUrl = "http://data.eastmoney.com/executive/gdzjc.html",Days = 30,TxtName = "股东增持股.txt"});
            //            co.ConfigWebs.Add(new ConfigWeb() {WebNamel = "东方财富",WebUrl = "http://data.eastmoney.com/executive/gdzjc.html",Days = 30,TxtName = "股东增持股.txt"});
            //            HHXml.SerializerXmlToFile(co,"Config.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;

                Dfcf d = new Dfcf();
                d.Parser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                button1.Enabled = true;
            }
        }
    }
}
