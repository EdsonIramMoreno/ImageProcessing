using System;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ProcesamientoImagenes
{
    public static class Filters
    {

        public static Bitmap negativeFilter(Bitmap img)
        {
            // Lock the bitmap's bits.  
            var image = img;
            int w = image.Width;
            int h = image.Height;
            BitmapData srcData = image.LockBits(new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            image.UnlockBits(srcData);
            int current = 0;
            int cChannels = 3;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    current = y * srcData.Stride + x * 4;
                    for (int c = 0; c < cChannels; c++)
                    {
                        result[current + c] = (byte)(255 - buffer[current + c]);
                    }
                    result[current + 3] = 255;
                }
            }
            Bitmap resImg = new Bitmap(w, h);
            BitmapData resData = resImg.LockBits(new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resData.Scan0, bytes);
            resImg.UnlockBits(resData);
            return resImg;
        }

        public static void exportImage(System.Drawing.Image img)
        {
            var im = ImageManager.getInstance();
            string workingDirectory = Environment.CurrentDirectory;
            string imageDirectory = Directory.GetParent(workingDirectory).Parent.FullName + "\\Files\\Exported\\";
            img.Save(imageDirectory + im.getImageName() + ".jpeg", ImageFormat.Jpeg);
            var result = MessageBox.Show("The image has been exported, do you want to open the folder it's been saved?.", "Exported Succesfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                Process.Start(imageDirectory);
            }
        }

    }
}
