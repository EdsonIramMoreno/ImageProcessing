using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;

namespace ProcesamientoImagenes
{
    public partial class Recognition : Form
    {
        private bool isDevice;
        private FilterInfoCollection myDevices;
        private VideoCaptureDevice myWebCam;
        static CascadeClassifier cascadeClassifier;

        public Recognition()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            var dir = Directory.GetCurrentDirectory();
            dir = System.IO.Directory.GetParent(dir).FullName;
            dir = System.IO.Directory.GetParent(dir).FullName;
            cascadeClassifier = new CascadeClassifier(dir + "//haarcascade_frontalface_alt_tree.xml");
        }

        private void Recognition_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pb_goBack.Width - 2, pb_goBack.Height - 2);
            Region rg = new Region(gp);
            pb_goBack.Region = rg;

            loadDevices();
        }

        private void pb_goBack_Click(object sender, EventArgs e)
        {
            var f = new Create_Project();
            this.Hide();
            f.Show();
            closeWebCam();
        }

        private void pB_Start_Click(object sender, EventArgs e)
        {
            if (isDevice)
            {
                closeWebCam();
                string nameDevice = myDevices[0].MonikerString;
                myWebCam = new VideoCaptureDevice(nameDevice);
                myWebCam.NewFrame += new NewFrameEventHandler(capture);
                myWebCam.Start();
            }
            else
            {
                MessageBox.Show("Please connect an audio input device.", "Error", MessageBoxButtons.OK);
            }
        }

        
        private void capture(object seneder, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(image);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            lbl_Count.Text = rectangles.Length.ToString();

            foreach (Rectangle rectangle in rectangles)
            {

                using (Graphics graphics = Graphics.FromImage(image))
                {

                    using (Pen pen = new Pen(Color.FromArgb(0, 255, 0), 5))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }

            pB_Recognition.Image = image;
        }

        private void loadDevices()
        {
            myDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (myDevices.Count > 0)
                isDevice = true;
            else
                isDevice = false;
        }

        public void closeWebCam()
        {
            if (myWebCam != null && myWebCam.IsRunning)
            {
                myWebCam.SignalToStop();
                myWebCam = null;

            }
        }

    }
}
