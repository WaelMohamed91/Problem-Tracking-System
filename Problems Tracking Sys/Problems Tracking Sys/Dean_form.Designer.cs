namespace Problems_Tracking_Sys
{
    partial class Dean_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Doctor_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor_Complaint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complaints_txt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.view_Doctor_complaints_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Replay_doc_btn = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.new_label = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doctor_Mail,
            this.Doctor_Complaint});
            this.dataGridView1.Location = new System.Drawing.Point(21, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 121);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Doctor_Mail
            // 
            this.Doctor_Mail.HeaderText = "Doctor Mail";
            this.Doctor_Mail.Name = "Doctor_Mail";
            this.Doctor_Mail.Width = 170;
            // 
            // Doctor_Complaint
            // 
            this.Doctor_Complaint.HeaderText = "Doctor Complaint";
            this.Doctor_Complaint.Name = "Doctor_Complaint";
            this.Doctor_Complaint.Width = 500;
            // 
            // Complaints_txt
            // 
            this.Complaints_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complaints_txt.Location = new System.Drawing.Point(21, 209);
            this.Complaints_txt.Multiline = true;
            this.Complaints_txt.Name = "Complaints_txt";
            this.Complaints_txt.Size = new System.Drawing.Size(326, 89);
            this.Complaints_txt.TabIndex = 2;
            this.Complaints_txt.TextChanged += new System.EventHandler(this.Complaints_txt_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(409, 209);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 89);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // view_Doctor_complaints_btn
            // 
            this.view_Doctor_complaints_btn.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.view_Doctor_complaints_btn.Appearance.Options.UseFont = true;
            this.view_Doctor_complaints_btn.Location = new System.Drawing.Point(268, 12);
            this.view_Doctor_complaints_btn.Name = "view_Doctor_complaints_btn";
            this.view_Doctor_complaints_btn.Size = new System.Drawing.Size(230, 35);
            this.view_Doctor_complaints_btn.TabIndex = 5;
            this.view_Doctor_complaints_btn.Text = "View Doctor Complains";
            this.view_Doctor_complaints_btn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Replay_doc_btn
            // 
            this.Replay_doc_btn.Appearance.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.Replay_doc_btn.Appearance.Options.UseFont = true;
            this.Replay_doc_btn.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.bo_validation;
            this.Replay_doc_btn.Location = new System.Drawing.Point(327, 304);
            this.Replay_doc_btn.Name = "Replay_doc_btn";
            this.Replay_doc_btn.Size = new System.Drawing.Size(93, 43);
            this.Replay_doc_btn.TabIndex = 6;
            this.Replay_doc_btn.Text = "Send";
            this.Replay_doc_btn.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 10F);
            this.label1.Location = new System.Drawing.Point(18, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doctor Complaint :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10F);
            this.label2.Location = new System.Drawing.Point(407, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Your Replay :";
            // 
            // new_label
            // 
            this.new_label.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_label.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.new_label.Appearance.Options.UseFont = true;
            this.new_label.Appearance.Options.UseForeColor = true;
            this.new_label.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.new_label.ImageOptions.SvgImage = global::Problems_Tracking_Sys.Properties.Resources.newcomment1;
            this.new_label.Location = new System.Drawing.Point(3, -3);
            this.new_label.Name = "new_label";
            this.new_label.Size = new System.Drawing.Size(202, 32);
            this.new_label.TabIndex = 9;
            this.new_label.Text = "New Compalint";
            this.new_label.Visible = false;
            this.new_label.Click += new System.EventHandler(this.new_label_Click);
            // 
            // Dean_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 351);
            this.Controls.Add(this.new_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Replay_doc_btn);
            this.Controls.Add(this.view_Doctor_complaints_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Complaints_txt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dean_form";
            this.Text = "Dean_form";
            this.Load += new System.EventHandler(this.Dean_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Complaints_txt;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton view_Doctor_complaints_btn;
        private DevExpress.XtraEditors.SimpleButton Replay_doc_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor_Complaint;
        private DevExpress.XtraEditors.LabelControl new_label;
    }
}