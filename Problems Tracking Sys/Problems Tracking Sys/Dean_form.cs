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
    public partial class Dean_form : Form
    {
        Doctor Doctor_obj;
        string Doc_mail;
        bool Notify; 
        public Dean_form()
        {
            InitializeComponent();
            Doctor_obj = new Doctor();
            Doctor_obj.load();
            Notify = false;
        }


        private void Dean_form_Load(object sender, EventArgs e)
        {
            Complaints_txt.ReadOnly = true;
            set_Table();
           
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            if (Notify)
                new_label.Visible = true;
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
        void Clear_components()
        {
            Complaints_txt.Text = "";
            textBox1.Text = "";
            
        }
        public void set_Table()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            for (int i = 0; i < Doctor_obj.Doctors.Count; i++)
            {
                for (int j = 0; j < Doctor_obj.Doctors[i].complaints.Count; j++)
                {
                    // Check To retrive just Complaints that has not Replaied
                    if (Doctor_obj.Doctors[i].Replaies[j] == "This complaint has not yet been Replaied ")
                    { dataGridView1.Rows.Add(Doctor_obj.Doctors[i].mail, Doctor_obj.Doctors[i].complaints[j]);
                        Notify = true; 
                    }

                }
            }

        }

        private void view_Doctor_complaints_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            set_Table();

        }
      

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           if (dataGridView1.RowCount > 1)
            {
                Complaints_txt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Doc_mail = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void Replay_doc_btn_Click(object sender, EventArgs e)
        {
            if (!replay_validation())
                return;

            if (Doctor_obj.Set_Replay(Doc_mail, Complaints_txt.Text, textBox1.Text))
            {
                MessageBox.Show("Done Replay ");
                Doctor_obj.Save();
                Clear_components();
                set_Table(); 

            }
            else
                MessageBox.Show("Replay Not sent ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Complaints_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            set_Table();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (!replay_validation())
                return;

            if (Doctor_obj.Set_Replay(Doc_mail, Complaints_txt.Text, textBox1.Text))
            {
                MessageBox.Show("Done Replay ");
                Doctor_obj.Save();
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
