namespace ProcesamientoImagenes
{
    partial class ProjectName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectName));
            this.pB_Image = new System.Windows.Forms.PictureBox();
            this.lbl_ProjectName = new System.Windows.Forms.Label();
            this.cBox_Filters = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.pb_goBack = new System.Windows.Forms.PictureBox();
            this.hB_R = new Emgu.CV.UI.HistogramBox();
            this.hB_G = new Emgu.CV.UI.HistogramBox();
            this.hB_B = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_goBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_Image
            // 
            this.pB_Image.Location = new System.Drawing.Point(52, 52);
            this.pB_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pB_Image.Name = "pB_Image";
            this.pB_Image.Size = new System.Drawing.Size(1080, 720);
            this.pB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Image.TabIndex = 0;
            this.pB_Image.TabStop = false;
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.AutoSize = true;
            this.lbl_ProjectName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProjectName.ForeColor = System.Drawing.Color.White;
            this.lbl_ProjectName.Location = new System.Drawing.Point(340, 11);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(77, 27);
            this.lbl_ProjectName.TabIndex = 5;
            this.lbl_ProjectName.Text = "Filter:";
            // 
            // cBox_Filters
            // 
            this.cBox_Filters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBox_Filters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_Filters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Filters.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Filters.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cBox_Filters.FormattingEnabled = true;
            this.cBox_Filters.ItemHeight = 23;
            this.cBox_Filters.Items.AddRange(new object[] {
            "Color_Gradient",
            "Gray_Scale ",
            "Negative ",
            "Noise ",
            "Sepia"});
            this.cBox_Filters.Location = new System.Drawing.Point(421, 11);
            this.cBox_Filters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBox_Filters.Name = "cBox_Filters";
            this.cBox_Filters.Size = new System.Drawing.Size(275, 31);
            this.cBox_Filters.TabIndex = 2;
            this.cBox_Filters.SelectedIndexChanged += new System.EventHandler(this.cBox_Filters_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hB_B);
            this.groupBox1.Controls.Add(this.hB_G);
            this.groupBox1.Controls.Add(this.hB_R);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(52, 776);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(900, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histogram";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(1032, 798);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 34);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Location = new System.Drawing.Point(1032, 850);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(100, 34);
            this.btn_Export.TabIndex = 1;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // pb_goBack
            // 
            this.pb_goBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pb_goBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_goBack.Image = ((System.Drawing.Image)(resources.GetObject("pb_goBack.Image")));
            this.pb_goBack.Location = new System.Drawing.Point(3, 1);
            this.pb_goBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_goBack.Name = "pb_goBack";
            this.pb_goBack.Size = new System.Drawing.Size(51, 50);
            this.pb_goBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_goBack.TabIndex = 14;
            this.pb_goBack.TabStop = false;
            this.pb_goBack.Click += new System.EventHandler(this.pb_goBack_Click);
            // 
            // hB_R
            // 
            this.hB_R.Location = new System.Drawing.Point(0, 0);
            this.hB_R.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hB_R.Name = "hB_R";
            this.hB_R.Size = new System.Drawing.Size(300, 150);
            this.hB_R.TabIndex = 0;
            // 
            // hB_G
            // 
            this.hB_G.Location = new System.Drawing.Point(308, -1);
            this.hB_G.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hB_G.Name = "hB_G";
            this.hB_G.Size = new System.Drawing.Size(300, 150);
            this.hB_G.TabIndex = 1;
            // 
            // hB_B
            // 
            this.hB_B.Location = new System.Drawing.Point(615, -2);
            this.hB_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hB_B.Name = "hB_B";
            this.hB_B.Size = new System.Drawing.Size(300, 150);
            this.hB_B.TabIndex = 2;
            // 
            // ProjectName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1181, 866);
            this.Controls.Add(this.pb_goBack);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cBox_Filters);
            this.Controls.Add(this.lbl_ProjectName);
            this.Controls.Add(this.pB_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProjectName";
            this.Text = "ProjectName";
            this.Load += new System.EventHandler(this.ProjectName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_goBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_Image;
        private System.Windows.Forms.Label lbl_ProjectName;
        private System.Windows.Forms.ComboBox cBox_Filters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.PictureBox pb_goBack;
        private Emgu.CV.UI.HistogramBox hB_B;
        private Emgu.CV.UI.HistogramBox hB_G;
        private Emgu.CV.UI.HistogramBox hB_R;
    }
}