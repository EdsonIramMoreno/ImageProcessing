namespace ProcesamientoImagenes
{
    partial class Recognition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recognition));
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.pb_goBack = new System.Windows.Forms.PictureBox();
            this.pB_Start = new System.Windows.Forms.PictureBox();
            this.pB_Recognition = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_goBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Recognition)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(443, 814);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(205, 33);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "People Count:";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Count.ForeColor = System.Drawing.Color.White;
            this.lbl_Count.Location = new System.Drawing.Point(654, 812);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(49, 35);
            this.lbl_Count.TabIndex = 6;
            this.lbl_Count.Text = "00";
            // 
            // pb_goBack
            // 
            this.pb_goBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pb_goBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_goBack.Image = ((System.Drawing.Image)(resources.GetObject("pb_goBack.Image")));
            this.pb_goBack.Location = new System.Drawing.Point(1, 2);
            this.pb_goBack.Name = "pb_goBack";
            this.pb_goBack.Size = new System.Drawing.Size(50, 50);
            this.pb_goBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_goBack.TabIndex = 15;
            this.pb_goBack.TabStop = false;
            this.pb_goBack.Click += new System.EventHandler(this.pb_goBack_Click);
            // 
            // pB_Start
            // 
            this.pB_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_Start.Image = ((System.Drawing.Image)(resources.GetObject("pB_Start.Image")));
            this.pB_Start.Location = new System.Drawing.Point(486, 12);
            this.pB_Start.Name = "pB_Start";
            this.pB_Start.Size = new System.Drawing.Size(100, 50);
            this.pB_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Start.TabIndex = 16;
            this.pB_Start.TabStop = false;
            this.pB_Start.Click += new System.EventHandler(this.pB_Start_Click);
            // 
            // pB_Recognition
            // 
            this.pB_Recognition.Location = new System.Drawing.Point(15, 68);
            this.pB_Recognition.Name = "pB_Recognition";
            this.pB_Recognition.Size = new System.Drawing.Size(1080, 720);
            this.pB_Recognition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Recognition.TabIndex = 18;
            this.pB_Recognition.TabStop = false;
            // 
            // Recognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1107, 863);
            this.Controls.Add(this.pB_Recognition);
            this.Controls.Add(this.pB_Start);
            this.Controls.Add(this.pb_goBack);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Recognition";
            this.Text = "Recognition";
            this.Load += new System.EventHandler(this.Recognition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_goBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Recognition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.PictureBox pb_goBack;
        private System.Windows.Forms.PictureBox pB_Start;
        private System.Windows.Forms.PictureBox pB_Recognition;
    }
}