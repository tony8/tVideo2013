using System;
using System.Collections.Generic;
using System.Text;

namespace tVideo2013
{
    //1.ͼƬ������������Сʱ������
    // ͼƬ�洢����  �ص� ���� ͨ������ ���� 
    //  ���ӣ����� 20150204 ����Ⱥ�ǡ���_ͨ��һ

    internal class tLog
    {
        /// <summary>
        /// ��¼��ʼҳ�棬����ʵʱ���
        /// </summary>
        /// <returns></returns>
        internal tLog() 
        {

            // �������ݴ洢��snapshot�ļ�����
            //����Ƿ����snapshot�ļ��У�û�о��½�һ��

        }
        bool readLog()
        {
            

            return true;
        }

        /// <summary>
        /// �������������ͼƬ
        /// </summary>
        /// <returns></returns>
        public bool picRecord() 
        {
            //����Ƿ�������ص���ļ��У�û�о��½�һ��

            //ͼƬ���� ����01_��������1��������_ͨ��1_20150204_195121(00000004)

            return true;
        }

        /// <summary>
        /// ���excel���е�ͳ��
        /// </summary>
        /// <returns></returns>
        public bool excelRecord() 
        {
            //
            return true;
        }

        /// <summary>
        /// ���ձ����ͼƬ�ļ����ϵ�λ���
        /// </summary>
        void changeFileName()
        {
            //String ffPath,ffName,fcPath,fcName,tmpStr,strRoot;
            ////strRoot="c:\\Hikvision\\Snapshot\\preview\\";
            ////ֻ��ʾ���� xxxx��xx��xx�� 
            //String dateStr =  DateTime.Now.ToString();
            ////�õ������� Сʱ������

            //File.Exists(constData.imgPath + dateStr + "?????.jpg");

        }

    }
}
