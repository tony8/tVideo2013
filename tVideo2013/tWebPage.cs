using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Runtime.InteropServices;
using System.Drawing;


namespace tVideo2013
{
    class tWebPage
    {
        public bool webOpenFlag;
        

        //���캯��
        public tWebPage() 
        {
            webOpenFlag = false;

        }
         
       // [DllImport("user32.dll", EntryPoint = "GetDesktopWindow", CharSet = CharSet.Auto, SetLastError = true)]
            
        //��½��ʵʱ�����ҳ
        public bool LoginWebSite()
        {        
            webOpenFlag = false;
            if ( OpenWeb() )                 //����ҳ
            {
                Thread.Sleep( constData.timeWait );
                if (  maxWebPage() )         //�����ҳ
                {
                    Thread.Sleep(constData.timeWait );
                    if( inputPassword(constData.img_web1,constData.Box_logIn) )   //��λ����������
                    {
                        Thread.Sleep( constData.timeWait );
                        if (  nextPageRealTimeMonitor() ) //����ʵʱ��ؽ��� 
                        {
                            Thread.Sleep(constData.timeWait );
                            webOpenFlag = true;
                        }                       
                    }
                }
            }
            return webOpenFlag;
        }
        /// <summary>
        /// �ر���ҳ
        /// </summary>
        /// <returns></returns>

       
        private bool closeWebPage()
        {//�ҵ��رհ�ť������ر�

            //�ҵ��رհ�ť
            //tImgProcess.
            return true;
        }
        
        /// <summary>
        /// ����ҳ
        /// </summary>
        /// <returns></returns>
        private bool OpenWeb()
        {//�򿪵�һ��ҳ�棬�Ҳ���url�򷵻��Ҳ���url 
            //string path = @"E:\Project\5.������Ŀ\TvideoCount\TvideoCount\bin\Debug\";
            string website =  constData.webName;
            string strpath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;

            if (!File.Exists( website ))
            {
                MessageBox.Show("�ļ��������������ļ�������", "����", MessageBoxButtons.OK);
                return false;
            }
            System.Diagnostics.Process.Start(website);         
            return true;
        }
 
        //����ҳ���
        private bool maxWebPage()
        {
            return true;
        }
        /// <summary>
        /// ���룺ͼƬ��ͼimg1,�ֲ�ͼƬbox������Ƿ�ɹ���������
        /// </summary>
        /// <param name="img1"></param>
        /// <param name="box"></param>
        /// <returns></returns>
        private bool inputPassword(string img1 ,string box)
        {
            //����Ļ���н�ͼ��ƥ���ҵ����������λ��

            //��ȡ��ǰ����ĻҶ�ͼƬ
            Image<Gray, byte> allGrayImg = tScreen.getScreen().Clone().Convert<Gray, byte>();
            Image<Gray, byte> boxImg = new Image<Gray, byte>(constData.BoxFilePath + constData.Box_logIn);
            Point LUP;//ƥ�������ֲ����Ͻǵ��������ȫ�ֵ�λ��
            BoxMatches.FindMatch(allGrayImg, boxImg, out LUP);


            //��������
            //ģ�������������
          

            return true;
        }
        private bool nextPageRealTimeMonitor()
        {//����ʵʱ���
            if(true)//û����ڶ�ҳ     
                closeWebPage();

            throw new Exception("The method or operation is not implemented.");
            return true;
        }
    }
}
