using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.GPU;
using Emgu.CV.UI;
using System.Windows.Forms;

namespace tVideo2013
{
    /// <summary>
    /// 桌面操作类，静态类，功能点：截屏，在桌面上画图
    /// </summary>
    static class tScreen
    {
        //对整个桌面进行截图
        public static Image<Bgr, Byte> getScreen()
        {
            //
            return new Image<Bgr, Byte>("");
        }

        //获得桌面句柄，然后画出一个矩形
        public static void drawPic(PointF LU, int width, int height )
        {
            //
          
           


        }

        //获得当前屏幕的长度
        public static int getScreenWeight()
        {
            return  SystemInformation.WorkingArea.Size.Width;
        }

        //获得当前屏幕的宽度
        public static int getScreenHeight()
        {
            return SystemInformation.WorkingArea.Size.Width;
        }


    }
}
