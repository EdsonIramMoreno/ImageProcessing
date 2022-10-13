using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ProcesamientoImagenes
{
    public partial class Recognition : Form
    {
        private bool isDevice;
        private FilterInfoCollection myDevices;
        private VideoCaptureDevice myWebCam;
        public Recognition()
        {
            InitializeComponent();
            
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
