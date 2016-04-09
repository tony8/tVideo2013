using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.GPU;
using Emgu.CV.UI;


namespace tVideo2013
{
    //识别定位某个局部包含2个步骤：1.检测出目标在整个屏幕的坐标
    //                             2.在屏幕上可视化这个目标
    //CWnd* pwnd = GetDesktopWindow();
  
 //获取当前桌面的设备上下文
// CDC* pdc = pwnd->GetWindowDC();
// for(int x = 0; x < 600; x++)
//  for(int y = 0; y < 400; y++)
//   pdc->SetPixel(x,y,0);
 
//我试过了，是可以画出一个600x400的黑色区域，不过很快被刷新掉了。

    //bool findPic(CBitmap* bitmap,CImage* pic,CPoint* pt);
    //在bitmap图像中搜索pic图像，将第一个匹配点写入pt，

    //bool findPicGray(CBitmap* bitmap,CImage* pic,CPoint* pt);
    //在bitmap图像中搜索pic图像，将第一个匹配点写入pt，

    //bool findXWin7(CBitmap* bitmap,CPoint* pt);
    //在bitmap图像中搜索Win7的关闭图像，将第一个匹配点写入pt，

    //bool findMaxWin7(CBitmap* bitmap,CPoint* pt);
    //在bitmap图像中搜索Win7的最大化图标，将第一个匹配点写入pt

    //bool findOKWin7(CBitmap* bitmap,CPoint* pt);
    //在bitmap图像中搜索Win7的确定按钮，将第一个匹配点写入pt，
	
    class tImgProcess
    {
        
        
        
        /// <summary>
        /// 核心函数，输入图片和局部图片，输出左上角点和长度宽度
        /// </summary>
        /// <returns></returns>
        private Point findlocation() 
        {//
            return new Point(1,1);
        }
        /// <summary>
        /// 抓取单个摄像头的图
        /// </summary>
        /// <returns></returns>
        bool dakaiSingle()
        {
            return true;
        }
        /// <summary>
        /// 在bitmap图像中搜索Win7的最大化图标
        /// </summary>
        /// <returns></returns>
        bool findMaxWin7()
        {
            //Image<Bgr, byte> input_img = new Image<Bgr, byte>();
            //Image<Bgr, byte> box = new Image<Bgr, byte>(); 
            ////Image<Bgr, Byte> input_img,Image<Bgr, Byte> box
            //SURFFeature maxWin7 = new SURFFeature();
            long matchTime;
            using (Image<Gray, Byte> modelImage = new Image<Gray, byte>("box.png"))
            using (Image<Gray, Byte> observedImage = new Image<Gray, byte>("box_in_scene.png"))
            {
                Image<Bgr, byte> result = BoxMatches.Draw(modelImage, observedImage, out matchTime);
                ImageViewer.Show(result, String.Format("Matched using {0} in {1} milliseconds", GpuInvoke.HasCuda ? "GPU" : "CPU", matchTime));
            }

            return true;
        }

        /// <summary>
        /// 在bitmap图像中搜索Win7的关闭图像，
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
        bool findOKWin7()
        {
            return true;
        }
        /// <summary>
        /// 在bitmap图像中搜索pic图像
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="pic"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
        bool findPic()
        {
            return true;
        }
        /// <summary>
        /// 在bitmap图像中搜索pic图像
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="pic"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
        bool findPicGray()//
        {
            return true;
        }
        /// <summary>
        /// 在bitmap图像中搜索pic图像,从pBegin开始，到pEnd结束
        /// </summary>
        /// <param name="pBegin"></param>
        /// <param name="pEnd"></param>
        /// <param name="bitmap"></param>
        /// <param name="pic"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
        bool InRangeFindPic()
        {
            return true;
        }
        /// <summary>
        /// 在bitmap图像中,从pBegin开始，到pEnd结束,判断视频是否为有效视频
        /// </summary>
        /// <param name="pBegin"></param>
        /// <param name="pEnd"></param>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        bool InRangeIsConnect()
        {
            return true;
        }
        /// <summary>
        /// 判断该单位是否有通道连入
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
        bool isCamOn()
        {
            return true;
        }
    }
}
