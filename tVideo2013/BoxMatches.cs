using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.GPU;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace tVideo2013
{
   public static class BoxMatches
   {
        public static void FindMatch(
            Image<Gray, Byte> modelImage,
            Image<Gray, byte> observedImage,
            out Point matchTime
           )
        {
            matchTime = new Point(1, 1);
        }

   }
}
