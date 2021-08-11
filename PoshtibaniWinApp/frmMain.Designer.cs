namespace PoshtibaniWinApp
{
    partial class frmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnReportEmp = new System.Windows.Forms.Button();
            this.btnMenuEmp = new System.Windows.Forms.Button();
            this.btnReportMan = new System.Windows.Forms.Button();
            this.btnSalaryMan = new System.Windows.Forms.Button();
            this.btnMenuMan = new System.Windows.Forms.Button();
            this.pnlCS = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlCS.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PoshtibaniWinApp.Properties.Resources.BackGround;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.pnlProfile.Controls.Add(this.lblPost);
            this.pnlProfile.Controls.Add(this.lblName);
            this.pnlProfile.Controls.Add(this.picProfile);
            this.pnlProfile.Location = new System.Drawing.Point(743, 44);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(150, 150);
            this.pnlProfile.TabIndex = 1;
            // 
            // lblPost
            // 
            this.lblPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPost.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPost.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPost.Location = new System.Drawing.Point(0, 115);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(150, 30);
            this.lblPost.TabIndex = 2;
            this.lblPost.Text = "سمت";
            this.lblPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(0, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 40);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "نام و نام خانوادگی";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picProfile
            // 
            this.picProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.picProfile.Image = global::PoshtibaniWinApp.Properties.Resources.Profile;
            this.picProfile.Location = new System.Drawing.Point(0, 0);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(150, 75);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.pnlButtons.Controls.Add(this.pnlSide);
            this.pnlButtons.Controls.Add(this.btnReportEmp);
            this.pnlButtons.Controls.Add(this.btnMenuEmp);
            this.pnlButtons.Controls.Add(this.btnReportMan);
            this.pnlButtons.Controls.Add(this.btnSalaryMan);
            this.pnlButtons.Controls.Add(this.btnMenuMan);
            this.pnlButtons.Location = new System.Drawing.Point(743, 200);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(150, 419);
            this.pnlButtons.TabIndex = 2;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.pnlSide.Location = new System.Drawing.Point(0, -1);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(10, 50);
            this.pnlSide.TabIndex = 7;
            // 
            // btnReportEmp
            // 
            this.btnReportEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnReportEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportEmp.FlatAppearance.BorderSize = 0;
            this.btnReportEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportEmp.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReportEmp.Location = new System.Drawing.Point(0, 200);
            this.btnReportEmp.Name = "btnReportEmp";
            this.btnReportEmp.Size = new System.Drawing.Size(150, 50);
            this.btnReportEmp.TabIndex = 4;
            this.btnReportEmp.Text = "گزارش";
            this.btnReportEmp.UseVisualStyleBackColor = false;
            this.btnReportEmp.Click += new System.EventHandler(this.btnReportEmp_Click);
            // 
            // btnMenuEmp
            // 
            this.btnMenuEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuEmp.FlatAppearance.BorderSize = 0;
            this.btnMenuEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEmp.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMenuEmp.Location = new System.Drawing.Point(0, 150);
            this.btnMenuEmp.Name = "btnMenuEmp";
            this.btnMenuEmp.Size = new System.Drawing.Size(150, 50);
            this.btnMenuEmp.TabIndex = 3;
            this.btnMenuEmp.Text = "صفحه اصلی";
            this.btnMenuEmp.UseVisualStyleBackColor = false;
            this.btnMenuEmp.Click += new System.EventHandler(this.btnMenuEmp_Click);
            // 
            // btnReportMan
            // 
            this.btnReportMan.BackColor = System.Drawing.Color.Transparent;
            this.btnReportMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportMan.FlatAppearance.BorderSize = 0;
            this.btnReportMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportMan.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReportMan.Location = new System.Drawing.Point(0, 100);
            this.btnReportMan.Name = "btnReportMan";
            this.btnReportMan.Size = new System.Drawing.Size(150, 50);
            this.btnReportMan.TabIndex = 2;
            this.btnReportMan.Text = "گزارش";
            this.btnReportMan.UseVisualStyleBackColor = false;
            this.btnReportMan.Click += new System.EventHandler(this.btnReportMan_Click);
            // 
            // btnSalaryMan
            // 
            this.btnSalaryMan.BackColor = System.Drawing.Color.Transparent;
            this.btnSalaryMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalaryMan.FlatAppearance.BorderSize = 0;
            this.btnSalaryMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryMan.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSalaryMan.Location = new System.Drawing.Point(0, 50);
            this.btnSalaryMan.Name = "btnSalaryMan";
            this.btnSalaryMan.Size = new System.Drawing.Size(150, 50);
            this.btnSalaryMan.TabIndex = 1;
            this.btnSalaryMan.Text = "تنخواه";
            this.btnSalaryMan.UseVisualStyleBackColor = false;
            this.btnSalaryMan.Click += new System.EventHandler(this.btnSalaryMan_Click);
            // 
            // btnMenuMan
            // 
            this.btnMenuMan.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMan.FlatAppearance.BorderSize = 0;
            this.btnMenuMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMan.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMenuMan.Location = new System.Drawing.Point(0, 0);
            this.btnMenuMan.Name = "btnMenuMan";
            this.btnMenuMan.Size = new System.Drawing.Size(150, 50);
            this.btnMenuMan.TabIndex = 0;
            this.btnMenuMan.Text = "صفحه اصلی";
            this.btnMenuMan.UseVisualStyleBackColor = false;
            this.btnMenuMan.Click += new System.EventHandler(this.btnMenuMan_Click);
            // 
            // pnlCS
            // 
            this.pnlCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.pnlCS.Controls.Add(this.btnSetting);
            this.pnlCS.Controls.Add(this.btnClose);
            this.pnlCS.Location = new System.Drawing.Point(765, 625);
            this.pnlCS.Name = "pnlCS";
            this.pnlCS.Size = new System.Drawing.Size(110, 50);
            this.pnlCS.TabIndex = 2;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = global::PoshtibaniWinApp.Properties.Resources.Setting;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(50, 50);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            this.btnSetting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSetting_MouseDown);
            this.btnSetting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSetting_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::PoshtibaniWinApp.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(60, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseDown);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseUp);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.pnlMain.BackgroundImage = global::PoshtibaniWinApp.Properties.Resources.hejrat_logo;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlMain.Location = new System.Drawing.Point(29, 53);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(700, 600);
            this.pnlMain.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlCS);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlCS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlCS;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Button btnReportEmp;
        private System.Windows.Forms.Button btnMenuEmp;
        private System.Windows.Forms.Button btnReportMan;
        private System.Windows.Forms.Button btnSalaryMan;
        private System.Windows.Forms.Button btnMenuMan;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlSide;
    }
}

