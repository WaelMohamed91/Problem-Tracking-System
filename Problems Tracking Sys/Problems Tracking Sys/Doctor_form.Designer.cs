namespace Problems_Tracking_Sys
{
    partial class Doctor_form
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
            this.components = new System.ComponentModel.Container();
            this.txt = new System.Windows.Forms.TextBox();
            this.complaint_txt = new System.Windows.Forms.TextBox();
            this.replay_txt = new System.Windows.Forms.TextBox();
            this.view = new DevExpress.XtraEditors.SimpleButton();
            this.Student_Complaints = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.Send = new DevExpress.XtraEditors.SimpleButton();
            this.Replay_btn = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Complaints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_label = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(67, 56);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(297, 299);
            this.txt.TabIndex = 5;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // complaint_txt
            // 
            this.complaint_txt.Location = new System.Drawing.Point(370, 254);
            this.complaint_txt.Multiline = true;
            this.complaint_txt.Name = "complaint_txt";
            this.complaint_txt.Size = new System.Drawing.Size(338, 64);
            this.complaint_txt.TabIndex = 9;
            // 
            // replay_txt
            // 
            this.replay_txt.Location = new System.Drawing.Point(370, 325);
            this.replay_txt.Multiline = true;
            this.replay_txt.Name = "replay_txt";
            this.replay_txt.Size = new System.Drawing.Size(338, 60);
            this.replay_txt.TabIndex = 10;
            this.replay_txt.Text = "l";
            // 
            // view
            // 
            this.view.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.agendaview1;
            this.view.Location = new System.Drawing.Point(123, 12);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(183, 42);
            this.view.TabIndex = 12;
            this.view.Text = "view replaies";
            this.view.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Student_Complaints
            // 
            this.Student_Complaints.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.agendaview;
            this.Student_Complaints.Location = new System.Drawing.Point(441, 9);
            this.Student_Complaints.Name = "Student_Complaints";
            this.Student_Complaints.Size = new System.Drawing.Size(183, 42);
            this.Student_Complaints.TabIndex = 13;
            this.Student_Complaints.Text = "view Student_Complaints";
            this.Student_Complaints.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(141, 361);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(121, 24);
            this.simpleButton3.TabIndex = 14;
            this.simpleButton3.Text = "Write Complaint..";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // Send
            // 
            this.Send.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.actions_send3;
            this.Send.Location = new System.Drawing.Point(141, 391);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(121, 34);
            this.Send.TabIndex = 15;
            this.Send.Text = "Send To dean";
            this.Send.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Replay_btn
            // 
            this.Replay_btn.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.actions_send2;
            this.Replay_btn.Location = new System.Drawing.Point(470, 391);
            this.Replay_btn.Name = "Replay_btn";
            this.Replay_btn.Size = new System.Drawing.Size(111, 36);
            this.Replay_btn.TabIndex = 16;
            this.Replay_btn.Text = "Send Replay ";
            this.Replay_btn.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Complaints,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(370, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 193);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Complaints
            // 
            this.Complaints.HeaderText = "Complaints";
            this.Complaints.Name = "Complaints";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Student Complaint";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // new_label
            // 
            this.new_label.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_label.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.new_label.Appearance.Options.UseFont = true;
            this.new_label.Appearance.Options.UseForeColor = true;
            this.new_label.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.new_label.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.newcomment1;
            this.new_label.Location = new System.Drawing.Point(3, 2);
            this.new_label.Name = "new_label";
            this.new_label.Size = new System.Drawing.Size(202, 32);
            this.new_label.TabIndex = 17;
            this.new_label.Text = "New Compalint";
            this.new_label.Visible = false;
            // 
            // Doctor_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 437);
            this.Controls.Add(this.view);
            this.Controls.Add(this.new_label);
            this.Controls.Add(this.Replay_btn);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.Student_Complaints);
            this.Controls.Add(this.replay_txt);
            this.Controls.Add(this.complaint_txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt);
            this.Name = "Doctor_form";
            this.Text = "Doctor_form";
            this.Load += new System.EventHandler(this.Doctor_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox complaint_txt;
        private System.Windows.Forms.TextBox replay_txt;
        private DevExpress.XtraEditors.SimpleButton view;
        private DevExpress.XtraEditors.SimpleButton Student_Complaints;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton Send;
        private DevExpress.XtraEditors.SimpleButton Replay_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevExpress.XtraEditors.LabelControl new_label;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}