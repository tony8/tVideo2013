using System;
using System.Collections.Generic;
using System.Text;

namespace tVideo2013
{
    //1.图片命名用年月日小时分钟秒
    // 图片存储按照  地点 日期 通道名称 进行 
    //  例子：景宁 20150204 景宁群星—班_通道一

    internal class tLog
    {
        /// <summary>
        /// 登录初始页面，进入实时监控
        /// </summary>
        /// <returns></returns>
        internal tLog() 
        {

            // 整理内容存储在snapshot文件夹中
            //检查是否存在snapshot文件夹，没有就新建一个

        }
        bool readLog()
        {
            

            return true;
        }

        /// <summary>
        /// 这个函数整理保存图片
        /// </summary>
        /// <returns></returns>
        public bool picRecord() 
        {
            //检查是否有这个地点的文件夹，没有就新建一个

            //图片名称 莲都01_抢修中心1（单兵）_通道1_20150204_195121(00000004)

            return true;
        }

        /// <summary>
        /// 完成excel表中的统计
        /// </summary>
        /// <returns></returns>
        public bool excelRecord() 
        {
            //
            return true;
        }

        /// <summary>
        /// 给刚保存的图片文件加上单位标记
        /// </summary>
        void changeFileName()
        {
            //String ffPath,ffName,fcPath,fcName,tmpStr,strRoot;
            ////strRoot="c:\\Hikvision\\Snapshot\\preview\\";
            ////只显示日期 xxxx年xx月xx日 
            //String dateStr =  DateTime.Now.ToString();
            ////得到年月日 小时分钟秒

            //File.Exists(constData.imgPath + dateStr + "?????.jpg");

        }

    }
}
