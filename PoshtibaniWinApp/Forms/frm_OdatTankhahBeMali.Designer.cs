namespace PoshtibaniWinApp.Forms
{
    partial class frm_OdatTankhahBeMali
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
            this.comElat = new System.Windows.Forms.ComboBox();
            this.btnSabt = new System.Windows.Forms.Button();
            this.txtTozihat = new System.Windows.Forms.TextBox();
            this.txtMablagh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTozihat = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comElat
            // 
            this.comElat.FormattingEnabled = true;
            this.comElat.Items.AddRange(new object[] {
            "بازگشت تنخواه دوره ای",
            "سایر"});
            this.comElat.Location = new System.Drawing.Point(29, 104);
            this.comElat.Name = "comElat";
            this.comElat.Size = new System.Drawing.Size(207, 37);
            this.comElat.TabIndex = 8;
            this.comElat.SelectedIndexChanged += new System.EventHandler(this.comElat_SelectedIndexChanged);
            // 
            // btnSabt
            // 
            this.btnSabt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSabt.ForeColor = System.Drawing.Color.Black;
            this.btnSabt.Location = new System.Drawing.Point(103, 202);
            this.btnSabt.Name = "btnSabt";
            this.btnSabt.Size = new System.Drawing.Size(147, 36);
            this.btnSabt.TabIndex = 11;
            this.btnSabt.Text = "ثبت";
            this.btnSabt.UseVisualStyleBackColor = true;
            this.btnSabt.Click += new System.EventHandler(this.btnSabt_Click);
            // 
            // txtTozihat
            // 
            this.txtTozihat.Location = new System.Drawing.Point(29, 150);
            this.txtTozihat.Name = "txtTozihat";
            this.txtTozihat.Size = new System.Drawing.Size(207, 37);
            this.txtTozihat.TabIndex = 12;
            this.txtTozihat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMablagh
            // 
            this.txtMablagh.Location = new System.Drawing.Point(29, 59);
            this.txtMablagh.MaxLength = 18;
            this.txtMablagh.Name = "txtMablagh";
            this.txtMablagh.Size = new System.Drawing.Size(207, 37);
            this.txtMablagh.TabIndex = 5;
            this.txtMablagh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMablagh.TextChanged += new System.EventHandler(this.TxtMablagh_TextChanged);
            this.txtMablagh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMablagh_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "توضیحات: ";
            // 
            // lblTozihat
            // 
            this.lblTozihat.AutoSize = true;
            this.lblTozihat.Location = new System.Drawing.Point(242, 153);
            this.lblTozihat.Name = "lblTozihat";
            this.lblTozihat.Size = new System.Drawing.Size(112, 29);
            this.lblTozihat.TabIndex = 10;
            this.lblTozihat.Text = "سایر توضیحات: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(89, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 38);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "عودت تنخواه به مالی";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "مبلغ: ";
            // 
            // frm_OdatTankhahBeMali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.comElat);
            this.Controls.Add(this.btnSabt);
            this.Controls.Add(this.txtTozihat);
            this.Controls.Add(this.txtMablagh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTozihat);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frm_OdatTankhahBeMali";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_OdatTankhahBeMali_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comElat;
        private System.Windows.Forms.Button btnSabt;
        private System.Windows.Forms.TextBox txtTozihat;
        private System.Windows.Forms.TextBox txtMablagh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTozihat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
    }
}