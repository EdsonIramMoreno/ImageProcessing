namespace ProcesamientoImagenes
{
    partial class Create_Project
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
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.rB_Photo = new System.Windows.Forms.RadioButton();
            this.rB_Video = new System.Windows.Forms.RadioButton();
            this.gBType = new System.Windows.Forms.GroupBox();
            this.rB_Recognition = new System.Windows.Forms.RadioButton();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.lbl_ProjectName = new System.Windows.Forms.Label();
            this.tBox_ProjectName = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.gBType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instructions.ForeColor = System.Drawing.Color.White;
            this.lbl_Instructions.Location = new System.Drawing.Point(1, 23);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(702, 39);
            this.lbl_Instructions.TabIndex = 0;
            this.lbl_Instructions.Text = "What will you be doing?";
            this.lbl_Instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rB_Photo
            // 
            this.rB_Photo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_Photo.ForeColor = System.Drawing.Color.White;
            this.rB_Photo.Location = new System.Drawing.Point(37, 40);
            this.rB_Photo.Name = "rB_Photo";
            this.rB_Photo.Size = new System.Drawing.Size(103, 24);
            this.rB_Photo.TabIndex = 1;
            this.rB_Photo.TabStop = true;
            this.rB_Photo.Text = "Photo";
            this.rB_Photo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rB_Photo.UseVisualStyleBackColor = true;
            this.rB_Photo.CheckedChanged += new System.EventHandler(this.rB_Photo_CheckedChanged);
            // 
            // rB_Video
            // 
            this.rB_Video.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_Video.ForeColor = System.Drawing.Color.White;
            this.rB_Video.Location = new System.Drawing.Point(466, 39);
            this.rB_Video.Name = "rB_Video";
            this.rB_Video.Size = new System.Drawing.Size(105, 25);
            this.rB_Video.TabIndex = 2;
            this.rB_Video.TabStop = true;
            this.rB_Video.Text = "Video";
            this.rB_Video.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rB_Video.UseVisualStyleBackColor = true;
            this.rB_Video.CheckedChanged += new System.EventHandler(this.rB_Video_CheckedChanged);
            // 
            // gBType
            // 
            this.gBType.Controls.Add(this.rB_Recognition);
            this.gBType.Controls.Add(this.rB_Video);
            this.gBType.Controls.Add(this.rB_Photo);
            this.gBType.Location = new System.Drawing.Point(50, 75);
            this.gBType.Name = "gBType";
            this.gBType.Size = new System.Drawing.Size(595, 100);
            this.gBType.TabIndex = 3;
            this.gBType.TabStop = false;
            // 
            // rB_Recognition
            // 
            this.rB_Recognition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_Recognition.ForeColor = System.Drawing.Color.White;
            this.rB_Recognition.Location = new System.Drawing.Point(226, 39);
            this.rB_Recognition.Name = "rB_Recognition";
            this.rB_Recognition.Size = new System.Drawing.Size(160, 25);
            this.rB_Recognition.TabIndex = 8;
            this.rB_Recognition.TabStop = true;
            this.rB_Recognition.Text = "Recognition";
            this.rB_Recognition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rB_Recognition.UseVisualStyleBackColor = true;
            this.rB_Recognition.CheckedChanged += new System.EventHandler(this.rB_Recognition_CheckedChanged);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Browse.FlatAppearance.BorderSize = 0;
            this.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Browse.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Location = new System.Drawing.Point(310, 200);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(100, 35);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Visible = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.AutoSize = true;
            this.lbl_ProjectName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProjectName.ForeColor = System.Drawing.Color.White;
            this.lbl_ProjectName.Location = new System.Drawing.Point(47, 288);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(143, 24);
            this.lbl_ProjectName.TabIndex = 4;
            this.lbl_ProjectName.Text = "Project Name:";
            this.lbl_ProjectName.Visible = false;
            // 
            // tBox_ProjectName
            // 
            this.tBox_ProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tBox_ProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBox_ProjectName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_ProjectName.ForeColor = System.Drawing.Color.White;
            this.tBox_ProjectName.Location = new System.Drawing.Point(208, 287);
            this.tBox_ProjectName.Name = "tBox_ProjectName";
            this.tBox_ProjectName.Size = new System.Drawing.Size(438, 27);
            this.tBox_ProjectName.TabIndex = 5;
            this.tBox_ProjectName.Visible = false;
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create.FlatAppearance.BorderSize = 0;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.Location = new System.Drawing.Point(310, 360);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(100, 35);
            this.btn_Create.TabIndex = 9;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Visible = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // Create_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(702, 453);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.tBox_ProjectName);
            this.Controls.Add(this.lbl_ProjectName);
            this.Controls.Add(this.lbl_Instructions);
            this.Controls.Add(this.gBType);
            this.MaximizeBox = false;
            this.Name = "Create_Project";
            this.Text = "Create Project";
            this.Load += new System.EventHandler(this.Create_Project_Load);
            this.gBType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.RadioButton rB_Photo;
        private System.Windows.Forms.RadioButton rB_Video;
        private System.Windows.Forms.GroupBox gBType;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Label lbl_ProjectName;
        private System.Windows.Forms.TextBox tBox_ProjectName;
        private System.Windows.Forms.RadioButton rB_Recognition;
        private System.Windows.Forms.Button btn_Create;
    }
}

