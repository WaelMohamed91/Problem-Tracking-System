namespace Problems_Tracking_Sys
{
    partial class Student_form
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
            this.txt = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.send_officer = new DevExpress.XtraEditors.SimpleButton();
            this.send_doc = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt.ForeColor = System.Drawing.Color.Silver;
            this.txt.Location = new System.Drawing.Point(258, 28);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(247, 213);
            this.txt.TabIndex = 2;
            this.txt.Text = "Write Here.....";
            this.txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(2, 41);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(201, 35);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Write Your Complaint ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // send_officer
            // 
            this.send_officer.Appearance.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_officer.Appearance.Options.UseFont = true;
            this.send_officer.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.actions_send1;
            this.send_officer.Location = new System.Drawing.Point(2, 191);
            this.send_officer.Name = "send_officer";
            this.send_officer.Size = new System.Drawing.Size(201, 33);
            this.send_officer.TabIndex = 6;
            this.send_officer.Text = "Send To Officer";
            this.send_officer.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // send_doc
            // 
            this.send_doc.Appearance.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_doc.Appearance.Options.UseFont = true;
            this.send_doc.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.actions_send;
            this.send_doc.Location = new System.Drawing.Point(2, 143);
            this.send_doc.Name = "send_doc";
            this.send_doc.Size = new System.Drawing.Size(201, 33);
            this.send_doc.TabIndex = 7;
            this.send_doc.Text = "Send To Doctor";
            this.send_doc.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(2, 91);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(201, 35);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "View All My Complaints ";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 266);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.send_doc);
            this.Controls.Add(this.send_officer);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txt);
            this.Name = "Student_form";
            this.Text = "Student_form";
            this.Load += new System.EventHandler(this.Student_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton send_officer;
        private DevExpress.XtraEditors.SimpleButton send_doc;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}