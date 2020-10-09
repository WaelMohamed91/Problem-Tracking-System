namespace Problems_Tracking_Sys
{
    partial class Form1
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
            this.mail_lbl = new System.Windows.Forms.Label();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.dean_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Student_Affairs_Officer_btn = new DevExpress.XtraEditors.SimpleButton();
            this.doc_btn = new DevExpress.XtraEditors.SimpleButton();
            this.officer_btn = new DevExpress.XtraEditors.SimpleButton();
            this.student_btn = new DevExpress.XtraEditors.SimpleButton();
            this.register_btn = new DevExpress.XtraEditors.SimpleButton();
            this.log_btn = new DevExpress.XtraEditors.SimpleButton();
            this.ok_btn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mail_lbl
            // 
            this.mail_lbl.AutoSize = true;
            this.mail_lbl.BackColor = System.Drawing.Color.Transparent;
            this.mail_lbl.Font = new System.Drawing.Font("Sitka Text", 13F);
            this.mail_lbl.Location = new System.Drawing.Point(155, 119);
            this.mail_lbl.Name = "mail_lbl";
            this.mail_lbl.Size = new System.Drawing.Size(61, 26);
            this.mail_lbl.TabIndex = 7;
            this.mail_lbl.Text = "mail :";
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pass_lbl.Font = new System.Drawing.Font("Sitka Text", 13F);
            this.pass_lbl.Location = new System.Drawing.Point(155, 165);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(103, 26);
            this.pass_lbl.TabIndex = 8;
            this.pass_lbl.Text = "password :";
            // 
            // mail_txt
            // 
            this.mail_txt.Location = new System.Drawing.Point(258, 123);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(147, 20);
            this.mail_txt.TabIndex = 10;
            this.mail_txt.TextChanged += new System.EventHandler(this.mail_txt_TextChanged);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(258, 169);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(147, 20);
            this.password_txt.TabIndex = 11;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // dean_btn
            // 
            this.dean_btn.Appearance.BackColor = System.Drawing.Color.White;
            this.dean_btn.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dean_btn.Appearance.Options.UseBackColor = true;
            this.dean_btn.Appearance.Options.UseFont = true;
            this.dean_btn.Location = new System.Drawing.Point(308, 36);
            this.dean_btn.Name = "dean_btn";
            this.dean_btn.Size = new System.Drawing.Size(188, 50);
            this.dean_btn.TabIndex = 13;
            this.dean_btn.Text = "Dean";
            this.dean_btn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Student_Affairs_Officer_btn
            // 
            this.Student_Affairs_Officer_btn.Appearance.BackColor = System.Drawing.Color.White;
            this.Student_Affairs_Officer_btn.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.Student_Affairs_Officer_btn.Appearance.Options.UseBackColor = true;
            this.Student_Affairs_Officer_btn.Appearance.Options.UseFont = true;
            this.Student_Affairs_Officer_btn.Location = new System.Drawing.Point(308, 94);
            this.Student_Affairs_Officer_btn.Name = "Student_Affairs_Officer_btn";
            this.Student_Affairs_Officer_btn.Size = new System.Drawing.Size(188, 50);
            this.Student_Affairs_Officer_btn.TabIndex = 14;
            this.Student_Affairs_Officer_btn.Text = "Student Affairs Officer";
            this.Student_Affairs_Officer_btn.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // doc_btn
            // 
            this.doc_btn.Appearance.BackColor = System.Drawing.Color.White;
            this.doc_btn.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.doc_btn.Appearance.Options.UseBackColor = true;
            this.doc_btn.Appearance.Options.UseFont = true;
            this.doc_btn.Location = new System.Drawing.Point(308, 152);
            this.doc_btn.Name = "doc_btn";
            this.doc_btn.Size = new System.Drawing.Size(188, 50);
            this.doc_btn.TabIndex = 15;
            this.doc_btn.Text = "doctor";
            this.doc_btn.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // officer_btn
            // 
            this.officer_btn.Appearance.BackColor = System.Drawing.Color.White;
            this.officer_btn.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.officer_btn.Appearance.Options.UseBackColor = true;
            this.officer_btn.Appearance.Options.UseFont = true;
            this.officer_btn.Location = new System.Drawing.Point(308, 210);
            this.officer_btn.Name = "officer_btn";
            this.officer_btn.Size = new System.Drawing.Size(188, 50);
            this.officer_btn.TabIndex = 16;
            this.officer_btn.Text = "Officer";
            this.officer_btn.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // student_btn
            // 
            this.student_btn.Appearance.BackColor = System.Drawing.Color.White;
            this.student_btn.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.student_btn.Appearance.Options.UseBackColor = true;
            this.student_btn.Appearance.Options.UseFont = true;
            this.student_btn.Location = new System.Drawing.Point(308, 268);
            this.student_btn.Name = "student_btn";
            this.student_btn.Size = new System.Drawing.Size(188, 50);
            this.student_btn.TabIndex = 17;
            this.student_btn.Text = "Student";
            this.student_btn.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // register_btn
            // 
            this.register_btn.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.register_btn.Appearance.Options.UseFont = true;
            this.register_btn.Location = new System.Drawing.Point(183, 84);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(162, 49);
            this.register_btn.TabIndex = 18;
            this.register_btn.Text = "register";
            this.register_btn.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // log_btn
            // 
            this.log_btn.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.log_btn.Appearance.Options.UseFont = true;
            this.log_btn.Location = new System.Drawing.Point(183, 156);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(162, 49);
            this.log_btn.TabIndex = 19;
            this.log_btn.Text = "login";
            this.log_btn.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(209, 208);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(109, 36);
            this.ok_btn.TabIndex = 20;
            this.ok_btn.Text = "OK";
            this.ok_btn.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.arrowleft;
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(35, 35);
            this.simpleButton1.Location = new System.Drawing.Point(0, 1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(43, 56);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(178, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Problems_Tracking_Sys.Properties.Resources._3d_wallpaper_download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.log_btn);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.student_btn);
            this.Controls.Add(this.officer_btn);
            this.Controls.Add(this.doc_btn);
            this.Controls.Add(this.Student_Affairs_Officer_btn);
            this.Controls.Add(this.dean_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.mail_lbl);
            this.Name = "Form1";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mail_lbl;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.TextBox mail_txt;
        private System.Windows.Forms.TextBox password_txt;
        private DevExpress.XtraEditors.SimpleButton dean_btn;
        private DevExpress.XtraEditors.SimpleButton Student_Affairs_Officer_btn;
        private DevExpress.XtraEditors.SimpleButton doc_btn;
        private DevExpress.XtraEditors.SimpleButton officer_btn;
        private DevExpress.XtraEditors.SimpleButton student_btn;
        private DevExpress.XtraEditors.SimpleButton register_btn;
        private DevExpress.XtraEditors.SimpleButton log_btn;
        private DevExpress.XtraEditors.SimpleButton ok_btn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
    }
}

