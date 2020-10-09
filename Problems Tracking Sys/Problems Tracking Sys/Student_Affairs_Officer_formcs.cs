using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problems_Tracking_Sys
{
    public partial class Student_Affairs_Officer_formcs : Form
    {
        string officer_mail;
        Officer officer_obj;
        bool notify; 
        public Student_Affairs_Officer_formcs()
        {
            InitializeComponent();
            officer_obj = new Officer();
            officer_obj.load();
            notify = false; 

        }
        void Clear_components ()
        {
            Complaints_txt.Text = "";
            textBox1.Text = "";
           
        }
        public bool replay_validation()
        {
            if (Complaints_txt.Text == "")
            {
                MessageBox.Show("Select one Complaints from Data Table !");
                return false;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Write Your Replay !");
                return false;
            }
            return true;
        }

        public void set_Table()
        {
            
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            for (int i = 0; i < officer_obj.Officers.Count; i++)
            {
                for (int j = 0; j < officer_obj.Officers[i].complaints.Count; j++)
                {
                    // Check To retrive just Complaints that has not Replaied
                    if (officer_obj.Officers[i].Replaies[j] == "This complaint has not yet been Replaied ")
                    {
                        dataGridView1.Rows.Add(officer_obj.Officers[i].mail, officer_obj.Officers[i].complaints[j]);

                        notify = true; 
                    }

                }
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                Complaints_txt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                officer_mail = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Complaints Yet...");
            }
        }

        private void view_Doctor_complaints_btn_Click(object sender, EventArgs e)
        {
           
            set_Table();
           


        }

        private void Replay_doc_btn_Click(object sender, EventArgs e)
        {
            if (!replay_validation())
                return;

            if (officer_obj.Set_Replay(officer_mail, Complaints_txt.Text, textBox1.Text))
            {
                MessageBox.Show("Done Replay ");
                officer_obj.Save();
                Clear_components();
                set_Table(); 

            }
            else
                MessageBox.Show("Replay Not sent ");
        }

        private void Student_Affairs_Officer_formcs_Load(object sender, EventArgs e)
        {
          
            set_Table();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (notify)
                new_label.Visible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            set_Table();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (!replay_validation())
                return;

            if (officer_obj.Set_Replay(officer_mail, Complaints_txt.Text, textBox1.Text))
            {
                MessageBox.Show("Done Replay ");
                officer_obj.Save();
                Clear_components();
                set_Table();

            }
            else
                MessageBox.Show("Replay Not sent ");
        }

        private void new_label_Click(object sender, EventArgs e)
        {

        }
    }
}
