using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Linq;
using Emgu.CV.Structure;
using Emgu.CV;

using System.Drawing.Drawing2D;
using MessageBox = System.Windows.Forms.MessageBox;
using Point = System.Drawing.Point;

namespace ProcesamientoImagenes
{
    public class Filters
    {
        private int[,,] buffer;
        Image<Gray, byte> R;
        Image<Gray, byte> G;
        Image<Gray, byte> B;

        public Bitmap negativeFilter(Bitmap img)
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
 
        public Bitmap noiseFilter(Bitmap img)
        {
            var image = img;
            int w = image.Width;
            int h = image.Height;

            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(image_data);

            byte[] noise = new byte[bytes];
            double[] erlang = new double[256];
            double a = 5.5;
            Random rnd = new Random();
            double sum = 0;

            for (int i = 0; i < 256; i++)
            {
                double step = (double)i * 0.01;
                if (step >= 0)
                {
                    erlang[i] = (double)(a * Math.Exp(-a * step));
                }
                else
                {
                    erlang[i] = 0;
                }
                sum += erlang[i];
            }

            for (int i = 0; i < 256; i++)
            {
                erlang[i] /= sum;
                erlang[i] *= bytes;
                erlang[i] = (int)Math.Floor(erlang[i]);
            }

            int count = 0;
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < (int)erlang[i]; j++)
                {
                    noise[j + count] = (byte)i;
                }
                count += (int)erlang[i];
            }

            for (int i = 0; i < bytes - count; i++)
            {
                noise[count + i] = 0;
            }

            noise = noise.OrderBy(x => rnd.Next()).ToArray();

            for (int i = 0; i < bytes; i++)
            {
                result[i] = (byte)(buffer[i] + noise[i]);
            }

            Bitmap result_image = new Bitmap(w, h);
            BitmapData result_data = result_image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, result_data.Scan0, bytes);
            result_image.UnlockBits(result_data);

            return result_image;
        }

        public Bitmap grayScaleFilter(Bitmap img)
        {
            var bmp = img;
            //Lock bitmap's bits to system memory
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

            //Scan for the first line
            IntPtr ptr = bmpData.Scan0;

            //Declare an array in which your RGB values will be stored
            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            //Copy RGB values in that array
            Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length; i += 3)
            {
                //Set RGB values in a Array where all RGB values are stored
                byte gray = (byte)(rgbValues[i] * .21 + rgbValues[i + 1] * .71 + rgbValues[i + 2] * .071);
                rgbValues[i] = rgbValues[i + 1] = rgbValues[i + 2] = gray;
            }

            //Copy changed RGB values back to bitmap
            Marshal.Copy(rgbValues, 0, ptr, bytes);

            //Unlock the bits
            bmp.UnlockBits(bmpData);

            return bmp;
        }

        public Bitmap sepiaFilter(Bitmap img)
        {
            var bmp = img;
            int width = bmp.Width;
            int height = bmp.Height;

            //color of pixel
            Color p;

            //sepia
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    p = bmp.GetPixel(x, y);

                    //extract pixel component ARGB
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //calculate temp value
                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    //set new RGB value
                    if (tr > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }

                    if (tg > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }

                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }

                    //set the new RGB value in image pixel
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return bmp;
        }

        public Bitmap colorGradientFilter(Bitmap img)
        {
            Rectangle fillRectangle = new Rectangle(0, 0, img.Width, img.Height);
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics g = Graphics.FromImage(bmp);
            Brush gradientBrush = new LinearGradientBrush(fillRectangle, ColorTranslator.FromHtml("#3a1c71"), ColorTranslator.FromHtml("#ffaf7b"), 180);
            g.FillRectangle(gradientBrush, fillRectangle);

            Color p;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    p = bmp.GetPixel(x, y);

                    //extract pixel component ARGB
                    int aa = p.A;
                    int rr = p.R;
                    int gg = p.G;
                    int bb = p.B;

                    bmp.SetPixel(x, y, Color.FromArgb(aa/2, rr, gg, bb));

                }
            }

                    Bitmap result = new Bitmap(Math.Max(img.Width, img.Width),
                             Math.Max(bmp.Height, bmp.Height));
            using (Graphics gr = Graphics.FromImage(result))
            {
                gr.DrawImage(img, Point.Empty);
                gr.DrawImage(bmp, Point.Empty);
            }
            return result;
        }

        public void exportImage(Image img)
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

        public Mat HistRed(Bitmap img)
        {
            var inputImg = new Image<Bgr, byte>(img);
            R = inputImg[2];

            DenseHistogram hist = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
            hist.Calculate(new Image<Gray, byte>[] { R }, false, null);
            Mat mat = new Mat();
            hist.CopyTo(mat);

            return mat;
        }

        public Mat HistGreen(Bitmap img)
        {
            var inputImg = new Image<Bgr, byte>(img);
            G = inputImg[1];

            DenseHistogram hist = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
            hist.Calculate(new Image<Gray, byte>[] { G }, false, null);
            Mat mat = new Mat();
            hist.CopyTo(mat);

            return mat;
        }

        public Mat HistBlue(Bitmap img)
        {
            var inputImg = new Image<Bgr, byte>(img);
            B = inputImg[0];

            DenseHistogram hist = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
            hist.Calculate(new Image<Gray, byte>[] { B }, false, null);
            Mat mat = new Mat();
            hist.CopyTo(mat);

            return mat;
        }
    }
}
