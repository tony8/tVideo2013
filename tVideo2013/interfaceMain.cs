using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tVideo2013
{
    public partial class interfaceMain : Form
    {
        int stepTime_min = 0;           //间隔时间
        private tWebPage myPage;        //打开网页类
        private tImgProcess myImgPro;   //图像处理
        private tLog myLog;             //日志类
        public interfaceMain()
        {
            InitializeComponent();
            myPage = new tWebPage();
            myImgPro = new tImgProcess();
            myLog = new tLog();
            interface_btn_init();
        }

        private void interface_btn_init()
        {//停止抓图为灰色，从文本中得到默认的时间间隔
            stepTime_min = constData.timeStepMin;
            textBoxStepMin.Text = stepTime_min.ToString();
            btn_StopPic.Enabled = false;
        }

        private void btn_GetPic_Click(object sender, EventArgs e)
        {
            //界面按钮处理，以及输入时间间隔处理
            interface_btn_GetPic();
            //登录到实时监控所在的第三个网页
            myPage.LoginWebSite();
            //开始抓图
        }
        private void interface_btn_GetPic()
        {
            //点击开始抓图后，
        }

        private void btn_StopPic_Click(object sender, EventArgs e)
        {
            //设置下按钮
            btn_GetPic.Enabled = true;
            btn_StopPic.Enabled = false;
            btnLog.Enabled = true;
            textBoxStepMin.Enabled = true;
            //停止抓图

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            //打开log.txt文件
            //获取当前.exe文件所在目录
            string logPath = System.Environment.CurrentDirectory;
            string logfile = logPath + constData.logFileName;
            if (!File.Exists(logPath))
            {
                //新建一个log.txt文件
                //using (StreamWriter sw = File.CreateText(constData.logFileName))
                //{
                //    string logdateCreate = DateTime.Now.ToString();
                //    sw.WriteLine("该日志文件新建于" + logdateCreate);                  
                //    sw.Close();
                //}
            }
            else
            {//打开日志文件
                System.Diagnostics.Process.Start(logfile);
            }
        }

        private void btn_Settle_Click(object sender, EventArgs e)
        {
            //1.对图片进行整理
            myLog.picRecord();
            //2.对excel表进行处理 
            myLog.excelRecord();
        }
    }
}
