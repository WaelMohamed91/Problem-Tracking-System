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
    public partial class Student_form : Form
    {
        Student student_obj;
      
        string current_student_mail; 
        public Student_form(string mail )
        {
            InitializeComponent();
           
            current_student_mail = mail;

        }
        private void Student_form_Load(object sender, EventArgs e)
        {
            txt.ReadOnly = true ;
            send_doc.Visible = false;
            send_officer.Visible = false;

            student_obj = new Student();
            student_obj.load();
           

        }

        private void write_Click(object sender, EventArgs e)
        {
            // Edit Componennts 
            txt.Text = ""; 
            send_officer.Visible = true;
            send_doc.Visible = true;
            txt.ReadOnly = false ;
            // ###########################
         

        }

        private void view_Click(object sender, EventArgs e)
        {
            // Edit Componennts 
            send_doc.Visible = false;
            send_officer.Visible = false;
            txt.ReadOnly = true;
            //##################################
            txt.Text = student_obj.View_ComplaintsWith_Replaies(current_student_mail); 


        }

        private void send_doc_Click(object sender, EventArgs e)
        {
            if (txt.Text == "")
            { MessageBox.Show("Enter Your Problem !");  return;  }
            student_obj.Add_Complaint_ToDoctor(current_student_mail, txt.Text.ToString());
            student_obj.Save();
            MessageBox.Show("Done");
            send_doc.Enabled = false; 


        }

        private void send_officer_Click(object sender, EventArgs e)
        {

            if (txt.Text == "")
            { MessageBox.Show("Enter Your Problem !"); return; }
            student_obj.Add_Complaint_ToOfficer(current_student_mail, txt.Text.ToString());
            student_obj.Save();
            MessageBox.Show("Done ");
            send_officer.Enabled = false; 

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Edit Componennts 
            txt.Text = "";
            send_officer.Visible = true;
            send_doc.Visible = true;
            txt.ReadOnly = false;
            txt.Text = "";
            txt.ForeColor = Color.Black;
            // ###########################
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // Edit Componennts 
            send_doc.Visible = false;
            send_officer.Visible = false;
            txt.ReadOnly = true;
            //##################################
            txt.Text = student_obj.View_ComplaintsWith_Replaies(current_student_mail);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (txt.Text == "")
            { MessageBox.Show("Enter Your Problem !"); return; }
            student_obj.Add_Complaint_ToDoctor(current_student_mail, txt.Text.ToString());
            student_obj.Save();
            MessageBox.Show("Done");
            send_doc.Enabled = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txt.Text == "")
            { MessageBox.Show("Enter Your Problem !"); return; }
            student_obj.Add_Complaint_ToOfficer(current_student_mail, txt.Text.ToString());
            student_obj.Save();
            MessageBox.Show("Done ");
            send_officer.Enabled = false;
        }

        private void txt_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
