using System;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ProcesamientoImagenes
{
    public partial class Create_Project : Form
    {
        public Create_Project()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(rB_Photo.Checked || rB_Video.Checked)
            {
                ProjectName window = new ProjectName();
                window.Show();
            }
            else
            {
                Recognition window = new Recognition();
                window.Show();
            }
        }

        private void Create_Project_Load(object sender, EventArgs e)
        {
        }

        private void rB_Photo_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_Photo.Checked)
            {
                var im = ImageManager.getInstance();
                im.setIsPhoto(true);
                btn_Browse.Visible = true;
                lbl_ProjectName.Visible = true;
                tBox_ProjectName.Visible = true;
                btn_Create.Visible = true;
                btn_Create.Location = new System.Drawing.Point(btn_Create.Location.X, 292);
                this.ClientSize = new System.Drawing.Size(this.ClientSize.Width, 368);
                btn_Browse.BackColor = btn_Create.BackColor;
                im.setImage(null);
            }
        }

        private void rB_Video_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_Video.Checked)
            {
                var im = ImageManager.getInstance();
                im.setIsPhoto(false);
                btn_Browse.Visible = true;
                lbl_ProjectName.Visible = true;
                tBox_ProjectName.Visible = true;
                btn_Create.Visible = true;
                btn_Create.Location = new System.Drawing.Point(btn_Create.Location.X, 292);
                this.ClientSize = new System.Drawing.Size(this.ClientSize.Width, 368);
                btn_Browse.BackColor = btn_Create.BackColor;
                im.setImage(null);
            }
        }

        private void rB_Recognition_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_Recognition.Checked)
            {
                btn_Browse.Visible = false;
                lbl_ProjectName.Visible = false;
                tBox_ProjectName.Visible = false;
                btn_Create.Visible = true;
                btn_Create.Location = new System.Drawing.Point(btn_Create.Location.X, 162);
                this.ClientSize = new System.Drawing.Size(this.ClientSize.Width, 225);
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            var im = ImageManager.getInstance();
            var opDialog = new OpenFileDialog();
            if (im.isPhoto())
                opDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG;";
            else
                opDialog.Filter = "Video Files(*.MP4;*.WMV;*.AVI)|*.MP4;*.WMV;*.AVI;";

            if (opDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if(im.isPhoto() || !im.isPhoto())
                        im.setImage(new Bitmap(opDialog.FileName));

                    btn_Browse.BackColor = Color.Green;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if(rB_Photo.Checked || rB_Video.Checked)
            {
                var im = ImageManager.getInstance();

                if (im.getImage() != null && tBox_ProjectName.Text != "")
                {
                    im.setImageName(tBox_ProjectName.Text);
                    var f = new ProjectName();
                    this.Hide();
                    f.Show();
                }
                else
                {
                    if(im.getImage() != null)
                        MessageBox.Show("Please select a file to continue.", "Error", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Please fill Project Name.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                var f = new Recognition();
                this.Hide();
                f.Show();
            }
        }
    }
}
