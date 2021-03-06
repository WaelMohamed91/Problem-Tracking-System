﻿using System;
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
    public partial class Officer_form : Form
    {
        bool Notify;  
        string current_officer_mail;
        string student_mail; 
        Officer officer_obj;
        Student student_obj;
       
        public Officer_form(string mail)
        {
            Notify = false; 
            InitializeComponent();
            current_officer_mail = mail;
            officer_obj = new Officer();
            officer_obj.load();
            student_obj = new Student();
            student_obj.load();

           

        }

        private void Officer_form_Load(object sender, EventArgs e)
        {
           

            txt.Visible = false;
            Send.Visible = false;
            dataGridView1.Visible = false;
            replay_txt.Visible = false;
            complaint_txt.Visible = false;
            Replay_btn.Visible = false;
            set_Table(); 
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (Notify)
                new_label.Visible = true;

        }
        public void set_Table()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            for (int i = 0; i < student_obj.students.Count; i++)
            {
                for (int j = 0; j < student_obj.students[i].complaints_ToOfficers.Count; j++)
                {
                    // Check To retrive just Complaints that has not Replaied
                    if (student_obj.students[i].Replaies_From_Officers[j] == "This complaint has not yet been Replaied ")
                    {
                        dataGridView1.Rows.Add(student_obj.students[i].mail, student_obj.students[i].complaints_ToOfficers[j]);
                        Notify=  true; 
                    }

                }
            }

        }

        private void write_Click(object sender, EventArgs e)
        {
            // Edit Components 
            txt.Visible = true;
            Send.Visible = true;
            Send.Enabled = true;
            dataGridView1.Visible = false;
            replay_txt.Visible = false;
            complaint_txt.Visible = false;
            Replay_btn.Visible = false;
            txt.Text = ""; 
            // ######################################

        }

        private void view_Click(object sender, EventArgs e)
        {
            // Edit Components 
            txt.Visible = true; 
            dataGridView1.Visible = false;
            replay_txt.Visible = false;
            complaint_txt.Visible = false;
            Replay_btn.Visible = false;
            Send.Visible = false;
            // ######################################

            txt.Text = officer_obj.view(current_officer_mail);

        }

        private void Student_Complaints_Click(object sender, EventArgs e)
        {// Edit Components 
            dataGridView1.Visible = true;
            replay_txt.Visible = true;
            complaint_txt.Visible = true;
            Replay_btn.Visible = true;
            txt.Visible = false;
            Send.Visible = false;
            // ####################################
            set_Table();


        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (txt.Text == "")
            { MessageBox.Show("Enter Your Problem !"); return; }

            officer_obj.Add_Complaints(current_officer_mail, txt.Text.ToString());
            officer_obj.Save();
            MessageBox.Show("Done");
        }
       

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            complaint_txt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            student_mail = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        public bool replay_validation()
        {
            if (complaint_txt.Text == "")
            {
                MessageBox.Show("Select one Complaints from Data Table !");
                return false;
            }
            if (replay_txt.Text == "")
            {
                MessageBox.Show("Write Your Replay !");
                return false;
            }
            return true;
        }

        private void Replay_btn_Click(object sender, EventArgs e)
        {
            if (!replay_validation())
                return;
            if (student_obj.Set_Replay_from_Officer(student_mail, complaint_txt.Text, replay_txt.Text))
            {
                MessageBox.Show("Done Replay ");
                student_obj.Save();
                set_Table();
                replay_txt.Text = ""; 

            }
            else
                MessageBox.Show("Replay Not sent ");

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Edit Components 
            txt.Text = "";
            txt.ForeColor = Color.Black;
            txt.Visible = true;
            txt.ReadOnly = false;

            Send.Visible = true;
            Send.Enabled = true;

            dataGridView1.Visible = false;
            replay_txt.Visible = false;
            complaint_txt.Visible = false;
            Replay_btn.Visible = false;
            
            // ######################################
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Edit Components 

            txt.Visible = true;
            txt.ReadOnly = true; 
            dataGridView1.Visible = false;
            replay_txt.Visible = false;
            complaint_txt.Visible = false;
            Replay_btn.Visible = false;
            Send.Visible = false;

            // ######################################

            txt.Text = officer_obj.view(current_officer_mail);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (txt.Text == "")
            { MessageBox.Show("Enter Your Problem !"); return; }

            officer_obj.Add_Complaints(current_officer_mail, txt.Text.ToString());
            officer_obj.Save();
            MessageBox.Show("Done");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // Edit Components 
            dataGridView1.Visible = true;
            replay_txt.Visible = true;
            
            complaint_txt.Visible = true;
            complaint_txt.ReadOnly = true; 
            Replay_btn.Visible = true;

            txt.Visible = false;
            Send.Visible = false;
            // ####################################
            set_Table();

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (!replay_validation())
                return;

            if (student_obj.Set_Replay_from_Officer(student_mail, complaint_txt.Text, replay_txt.Text))
            {
                MessageBox.Show("Done Replay ");
                student_obj.Save();
                set_Table();
                replay_txt.Text = "";

            }
            else
                MessageBox.Show("Replay Not sent ");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
