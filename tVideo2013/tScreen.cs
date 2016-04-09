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


namespace tVideo2013
{
    /// <summary>
    /// 桌面操作类，静态类，功能点：截屏，在桌面上画图
    /// </summary>
    static class tScreen
    {
        //对整个桌面进行截图
        static Image<Gray, Byte> getScreen()
        {
            //
            return new Image<Gray, Byte>("");
        }

        //获得桌面句柄，然后画出一个矩形
        static void drawPic(PointF LU, int width, int height )
        {
            //

        }

    }
}
