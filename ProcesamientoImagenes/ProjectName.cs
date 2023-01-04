using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Drawing;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace ProcesamientoImagenes
{
    public partial class ProjectName : Form
    {
        Image<Bgr, byte> currentFrame;
        Filters filters;
        public ProjectName()
        {
            InitializeComponent();
            filters = new Filters();
        }

        public enum filtersNames
        {
            Color_Gradient, Gray_Scale, Negative, Noise, Sepia
        }

        private void ProjectName_Load(object sender, EventArgs e)
        {
            var im = ImageManager.getInstance();
            this.Location = new System.Drawing.Point(50, 50);
            this.Height = this.Height + 50;
            this.Text = im.getImageName();

            if (im.isPhoto())
                pB_Image.Image = im.getImage();
            else
            {
                pB_Image.Image = null;
                btn_Export.Visible = true;
                btn_Export.Text = "Play";
                groupBox1.Visible = false;
            }
            

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pb_goBack.Width - 2, pb_goBack.Height - 2);
            Region rg = new Region(gp);
            pb_goBack.Region = rg;
        }

        private void pb_goBack_Click(object sender, EventArgs e)
        {
            var f = new Create_Project();
            this.Hide();
            f.Show();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            var im = ImageManager.getInstance();
            cBox_Filters.SelectedIndex = -1;
            var bmp = im.getImage();
            pB_Image.Image = null;
            pB_Image.Refresh();
            pB_Image.Image = bmp;
            hB_R.ClearHistogram();
            hB_G.ClearHistogram();
            hB_B.ClearHistogram();
            hB_R.Refresh();
            hB_G.Refresh();
            hB_B.Refresh();
        }

        private void cBox_Filters_SelectedIndexChanged(object sender, EventArgs e)
        {
            var im = ImageManager.getInstance();
            if (im.isPhoto())
            {
                var op = cBox_Filters.SelectedIndex;
                var bmp = im.getImage();
                bmp = (Bitmap)bmp.Clone();
                pB_Image.Image = null;
                pB_Image.Refresh();
                pB_Image.Image = bmp;
                switch (op)
                {
                    case (int)filtersNames.Negative:
                        pB_Image.Image = filters.negativeFilter(bmp);
                        break;
                    case (int)filtersNames.Noise:
                        pB_Image.Image = filters.noiseFilter(bmp);
                        break;
                    case (int)filtersNames.Gray_Scale:
                        pB_Image.Image = filters.grayScaleFilter(bmp);
                        break;
                    case (int)filtersNames.Sepia:
                        pB_Image.Image = filters.sepiaFilter(bmp);
                        break;
                    case (int)filtersNames.Color_Gradient:
                        pB_Image.Image = filters.colorGradientFilter(bmp);
                        break;
                    default:
                        break;

                }
                hB_R.ClearHistogram();
                hB_G.ClearHistogram();
                hB_B.ClearHistogram();

                var matRed = filters.HistRed(new Bitmap(pB_Image.Image));
                hB_R.AddHistogram("Red", Color.Red, matRed, 256, new float[] { 0f, 255.0f });

                var matGreen = filters.HistRed(new Bitmap(pB_Image.Image));
                hB_G.AddHistogram("Green", Color.Green, matGreen, 256, new float[] { 0f, 255.0f });

                var matBlue = filters.HistRed(new Bitmap(pB_Image.Image));
                hB_B.AddHistogram("Blue", Color.Blue, matBlue, 256, new float[] { 0f, 255.0f });

                hB_R.Refresh();
                hB_G.Refresh();
                hB_B.Refresh();
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            var im = ImageManager.getInstance();
            if(im.isPhoto())
                filters.exportImage(pB_Image.Image);
            else
            {
                Application.Idle += new EventHandler(playVideo);
            }
        }

        private void playVideo(object sender, EventArgs e)
        {
            
            var im = ImageManager.getInstance();
            if (im.getFrames() < im.getDuration() - 2)
            {
                Mat m = new Mat();
                im.getVideo().Read(m);

                currentFrame = new Image<Bgr, byte>(m.Bitmap);
                currentFrame.Resize(pB_Image.Width, pB_Image.Height, Inter.Cubic);
                im.setFrames(im.getVideo().GetCaptureProperty(CapProp.PosFrames));
            }
            else
            {
                im.setFrames(0);
                im.getVideo().SetCaptureProperty(CapProp.PosFrames, 0);
            }
            var op = cBox_Filters.SelectedIndex;

            switch (op)
            {
                case (int)filtersNames.Negative:
                    pB_Image.Image = filters.negativeFilter(currentFrame.Bitmap);
                    break;
                case (int)filtersNames.Noise:
                    pB_Image.Image = filters.noiseFilter(currentFrame.Bitmap);
                    break;
                case (int)filtersNames.Gray_Scale:
                    pB_Image.Image = filters.grayScaleFilter(currentFrame.Bitmap);
                    break;
                case (int)filtersNames.Sepia:
                    pB_Image.Image = filters.sepiaFilter(currentFrame.Bitmap);
                    break;
                case (int)filtersNames.Color_Gradient:
                    pB_Image.Image = filters.colorGradientFilter(currentFrame.Bitmap);
                    break;
                default:
                    pB_Image.Image = currentFrame.Bitmap;
                    break;

            }

        }
    }
}
