using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokloni.ba.WinUI
{
    public static class ImageHelper
    {
            #region ResizeImage
            public static Image ResizeImage(Image imgToResize, Size size)
            {
                int sourceWidth = imgToResize.Width;
                int sourceHeight = imgToResize.Height;

                float nPercent = 0;
                float nPercentW = 0;
                float nPercentH = 0;

                nPercentW = ((float)size.Width / (float)sourceWidth);
                nPercentH = ((float)size.Height / (float)sourceHeight);

                if (nPercentH < nPercentW)
                    nPercent = nPercentH;
                else
                    nPercent = nPercentW;

                int destWidth = (int)(sourceWidth * nPercent);
                int destHeight = (int)(sourceHeight * nPercent);

                Bitmap b = new Bitmap(destWidth, destHeight);
                Graphics g = Graphics.FromImage((Image)b);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
                g.Dispose();

                return (Image)b;
            }
            #endregion

            //#region AddDefaultPicture
            //public static byte[] AddDefaultPictureFull()
            //{
            //    Image orgImg;

            //    MemoryStream ms = new MemoryStream();
            //    orgImg = Properties.Settings.Default;
            //    orgImg.Save(ms, ImageFormat.Jpeg);

            //    return ms.ToArray();
            //}

            //public static byte[] AddDefaultPictureResized()
            //{
            //    Image resizedImg;

            //    MemoryStream ms = new MemoryStream();
            //    resizedImg = ResizeImage(Properties.Resources._default, new Size(Global.ResizeWidth, Global.ResizeHeight));
            //    resizedImg.Save(ms, ImageFormat.Jpeg);

            //    return ms.ToArray();
            //}
        }
    }
