using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Alca259.ImageBatcher.Common.Helpers
{
    public static class ImageHelper
    {
        public static void ResizePictureNoAspectRatio(string originFilename, string destinationFilename, int finalWidth, int finalHeight)
        {
            var bmp = new Bitmap(originFilename);

            int iWidth;
            int iHeight;
            if ((finalHeight == 0) && (finalWidth != 0))
            {
                iWidth = finalWidth;
                iHeight = (bmp.Size.Height * iWidth / bmp.Size.Width);
            }
            else if ((finalHeight != 0) && (finalWidth == 0))
            {
                iHeight = finalHeight;
                iWidth = (bmp.Size.Width * iHeight / bmp.Size.Height);
            }
            else
            {
                iWidth = finalWidth;
                iHeight = finalHeight;
            }

            var newBmp = new Bitmap(iWidth, iHeight);
            var graphicTemp = Graphics.FromImage(newBmp);

            graphicTemp.CompositingMode = CompositingMode.SourceOver;
            graphicTemp.CompositingQuality = CompositingQuality.HighQuality;
            graphicTemp.SmoothingMode = SmoothingMode.HighQuality;
            graphicTemp.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphicTemp.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphicTemp.DrawImage(bmp, 0, 0, iWidth, iHeight);
            graphicTemp.Dispose();

            newBmp.Save(destinationFilename);

            newBmp.Dispose();
            bmp.Dispose();
        }

        public static void ResizePictureAspectRatio(string originalFilename, string destinationFilename, int canvasWidth, int canvasHeight)
        {
            var originalImage = Image.FromFile(originalFilename);

            var originalWidth = originalImage.Size.Width;
            var originalHeight = originalImage.Size.Height;

            #region Ratio
            // Figure out the ratio
            var ratioX = (double)canvasWidth / (double)originalWidth;
            var ratioY = (double)canvasHeight / (double)originalHeight;
            // use whichever multiplier is smaller
            var ratio = ratioX < ratioY ? ratioX : ratioY;

            // now we can get the new height and width
            var newHeight = Convert.ToInt32(originalHeight * ratio);
            var newWidth = Convert.ToInt32(originalWidth * ratio);

            // Now calculate the X,Y position of the upper-left corner 
            // (one of these will always be zero)
            var posX = Convert.ToInt32((canvasWidth - (originalWidth * ratio)) / 2);
            var posY = Convert.ToInt32((canvasHeight - (originalHeight * ratio)) / 2);
            #endregion

            Image finalImage = new Bitmap(canvasWidth, canvasHeight);
            var finalGraphic = Graphics.FromImage(finalImage);

            finalGraphic.CompositingMode = CompositingMode.SourceOver;
            finalGraphic.CompositingQuality = CompositingQuality.HighQuality;
            finalGraphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            finalGraphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            finalGraphic.SmoothingMode = SmoothingMode.HighQuality;
            finalGraphic.Clear(Color.FromArgb(0, Color.White)); // white transparent padding
            finalGraphic.DrawImage(originalImage, posX, posY, newWidth, newHeight);
            finalGraphic.Dispose();

            finalImage.Save(destinationFilename);

            finalImage.Dispose();
            originalImage.Dispose();
        }
    }
}
