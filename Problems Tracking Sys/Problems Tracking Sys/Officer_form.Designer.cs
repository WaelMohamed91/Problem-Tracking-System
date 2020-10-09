namespace Problems_Tracking_Sys
{
    partial class Officer_form
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
            this.replay_txt = new System.Windows.Forms.TextBox();
            this.complaint_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complaints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.write = new DevExpress.XtraEditors.SimpleButton();
            this.Student_Complaints = new DevExpress.XtraEditors.SimpleButton();
            this.Send = new DevExpress.XtraEditors.SimpleButton();
            this.Replay_btn = new DevExpress.XtraEditors.SimpleButton();
            this.new_label = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // replay_txt
            // 
            this.replay_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay_txt.Location = new System.Drawing.Point(383, 232);
            this.replay_txt.Multiline = true;
            this.replay_txt.Name = "replay_txt";
            this.replay_txt.Size = new System.Drawing.Size(338, 64);
            this.replay_txt.TabIndex = 19;
            this.replay_txt.Text = "Write Here Your Repalay..";
            // 
            // complaint_txt
            // 
            this.complaint_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaint_txt.Location = new System.Drawing.Point(383, 299);
            this.complaint_txt.Multiline = true;
            this.complaint_txt.Name = "complaint_txt";
            this.complaint_txt.Size = new System.Drawing.Size(338, 64);
            this.complaint_txt.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentmail,
            this.Complaints});
            this.dataGridView1.Location = new System.Drawing.Point(383, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 177);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // studentmail
            // 
            this.studentmail.HeaderText = "Student_Mail";
            this.studentmail.Name = "studentmail";
            // 
            // Complaints
            // 
            this.Complaints.HeaderText = "Complaints";
            this.Complaints.Name = "Complaints";
            this.Complaints.Width = 200;
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt.ForeColor = System.Drawing.Color.Silver;
            this.txt.Location = new System.Drawing.Point(75, 49);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(290, 315);
            this.txt.TabIndex = 14;
            this.txt.Text = "Write Complaint Here...";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.agendaview2;
            this.simpleButton1.Location = new System.Drawing.Point(130, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(183, 42);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "view replaies";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // write
            // 
            this.write.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.write.Location = new System.Drawing.Point(151, 368);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(121, 24);
            this.write.TabIndex = 22;
            this.write.Text = "Write Complaint...";
            this.write.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Student_Complaints
            // 
            this.Student_Complaints.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.agendaview3;
            this.Student_Complaints.Location = new System.Drawing.Point(451, 4);
            this.Student_Complaints.Name = "Student_Complaints";
            this.Student_Complaints.Size = new System.Drawing.Size(183, 42);
            this.Student_Complaints.TabIndex = 23;
            this.Student_Complaints.Text = "view Student_Complaints";
            this.Student_Complaints.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // Send
            // 
            this.Send.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.actions_send5;
            this.Send.Location = new System.Drawing.Point(151, 398);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(121, 34);
            this.Send.TabIndex = 24;
            this.Send.Text = "Send To dean";
            this.Send.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Replay_btn
            // 
            this.Replay_btn.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.actions_send6;
            this.Replay_btn.Location = new System.Drawing.Point(490, 369);
            this.Replay_btn.Name = "Replay_btn";
            this.Replay_btn.Size = new System.Drawing.Size(111, 36);
            this.Replay_btn.TabIndex = 25;
            this.Replay_btn.Text = "Send Replay";
            this.Replay_btn.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // new_label
            // 
            this.new_label.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_label.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.new_label.Appearance.Options.UseFont = true;
            this.new_label.Appearance.Options.UseForeColor = true;
            this.new_label.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.new_label.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.newcomment1;
            this.new_label.Location = new System.Drawing.Point(2, 4);
            this.new_label.Name = "new_label";
            this.new_label.Size = new System.Drawing.Size(202, 32);
            this.new_label.TabIndex = 26;
            this.new_label.Text = "New Compalint";
            this.new_label.Visible = false;
            // 
            // Officer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 437);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.new_label);
            this.Controls.Add(this.Replay_btn);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Student_Complaints);
            this.Controls.Add(this.write);
            this.Controls.Add(this.replay_txt);
            this.Controls.Add(this.complaint_txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt);
            this.Name = "Officer_form";
            this.Text = "Officer_form";
            this.Load += new System.EventHandler(this.Officer_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox replay_txt;
        private System.Windows.Forms.TextBox complaint_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complaints;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton write;
        private DevExpress.XtraEditors.SimpleButton Student_Complaints;
        private DevExpress.XtraEditors.SimpleButton Send;
        private DevExpress.XtraEditors.SimpleButton Replay_btn;
        private DevExpress.XtraEditors.LabelControl new_label;
    }
}