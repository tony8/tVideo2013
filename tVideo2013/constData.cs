using System;
using System.Collections.Generic;
using System.Text;

namespace tVideo2013
{
    class constData
    {
        //文件的路径
        public const string BoxFilePath = @"\pic";          //模板图片文件的地址
        public const string logFilePath = @"\pic";          //日志文件的地址
        public const string imgSavePath = @"\pic";          //保存截图的路径

        //约定名称      
        public const string logFileName = "log.txt";          //日志文件
        public const string img_web1 = "web1.jpg";            //登陆用户名界面，动态获得
        public const string Box_logIn   = "Box_logIn.jpg";    //登陆用户名定位模板
        public const string img_web2 = "web2.jpg";         //输入密码后的界面，动态获得
        public const string real_time_mointor = "RTM.jpg";    //实时监控模板

        public const string maxWin7Box  = "Box_MinMaxClosed.jpg";                //最小化、最大化、关闭按钮的模板 

        //public const string real_time_mointor = "RTM.jpg";      //开始每个县每个通道扫描
 
        //启动
        public const string webName = "视频监控平台.url";
        public const int timeStepMin = 5;                      //默认时间间隔
        public const int timeWait = 500;                    //打开网页点击操作后等待的时长，单位毫秒
    }
}
