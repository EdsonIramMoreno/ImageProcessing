using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProcesamientoImagenes
{
        
    public partial class ProjectName : Form
    {
        public ProjectName()
        {
            InitializeComponent();
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

            pB_Image.Image = im.getImage();

            if (im.isPhoto())
                pB_Image.Image = im.getImage();
            else
            {
                //pB_Image.Image = null;
                btn_Export.Visible = false;
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
            pB_Image.Image = im.getImage();
        }

        private void cBox_Filters_SelectedIndexChanged(object sender, EventArgs e)
        {
            var im = ImageManager.getInstance();
            var op = cBox_Filters.SelectedIndex;
            switch (op)
            {
                case (int)filtersNames.Negative:
                    pB_Image.Image = Filters.negativeFilter(im.getImage());
                    break;
                default:
                    break;

            }

                
        }
    }
}
