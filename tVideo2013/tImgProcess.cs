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
    //ʶ��λĳ���ֲ�����2�����裺1.����Ŀ����������Ļ������
    //                             2.����Ļ�Ͽ��ӻ����Ŀ��
    //CWnd* pwnd = GetDesktopWindow();
  
 //��ȡ��ǰ������豸������
// CDC* pdc = pwnd->GetWindowDC();
// for(int x = 0; x < 600; x++)
//  for(int y = 0; y < 400; y++)
//   pdc->SetPixel(x,y,0);
 
//���Թ��ˣ��ǿ��Ի���һ��600x400�ĺ�ɫ���򣬲����ܿ챻ˢ�µ��ˡ�

    //bool findPic(CBitmap* bitmap,CImage* pic,CPoint* pt);
    //��bitmapͼ��������picͼ�񣬽���һ��ƥ���д��pt��

    //bool findPicGray(CBitmap* bitmap,CImage* pic,CPoint* pt);
    //��bitmapͼ��������picͼ�񣬽���һ��ƥ���д��pt��

    //bool findXWin7(CBitmap* bitmap,CPoint* pt);
    //��bitmapͼ��������Win7�Ĺر�ͼ�񣬽���һ��ƥ���д��pt��

    //bool findMaxWin7(CBitmap* bitmap,CPoint* pt);
    //��bitmapͼ��������Win7�����ͼ�꣬����һ��ƥ���д��pt

    //bool findOKWin7(CBitmap* bitmap,CPoint* pt);
    //��bitmapͼ��������Win7��ȷ����ť������һ��ƥ���д��pt��
	
    class tImgProcess
    {
        
        
        
        /// <summary>
        /// ���ĺ���������ͼƬ�;ֲ�ͼƬ��������Ͻǵ�ͳ��ȿ��
        /// </summary>
        /// <returns></returns>
        private Point findlocation() 
        {//
            return new Point(1,1);
        }
        /// <summary>
        /// ץȡ��������ͷ��ͼ
        /// </summary>
        /// <returns></returns>
        bool dakaiSingle()
        {
            return true;
        }
        /// <summary>
        /// ��bitmapͼ��������Win7�����ͼ��
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
        /// ��bitmapͼ��������Win7�Ĺر�ͼ��
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
        bool findOKWin7()
        {
            return true;
        }
        /// <summary>
        /// ��bitmapͼ��������picͼ��
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
        /// ��bitmapͼ��������picͼ��
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
        /// ��bitmapͼ��������picͼ��,��pBegin��ʼ����pEnd����
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
        /// ��bitmapͼ����,��pBegin��ʼ����pEnd����,�ж���Ƶ�Ƿ�Ϊ��Ч��Ƶ
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
        /// �жϸõ�λ�Ƿ���ͨ������
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
