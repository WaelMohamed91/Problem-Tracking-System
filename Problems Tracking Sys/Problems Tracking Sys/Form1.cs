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
    public partial class Form1 : Form
    {
        bool dean = false, student = false, officer = false, doctor = false, register = false, login = false, Student_Affairs_Officer = false;
        Student student_obj;
        Doctor doctor_obj;
        Officer Officer_obj; 


        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dean = student = officer = doctor = login = register = Student_Affairs_Officer  = false;
            log_btn.Visible = false;
            register_btn.Visible = false;
            ok_btn.Visible = false;
            mail_txt.Visible = false;
            password_txt.Visible = false;
            mail_lbl.Visible = false;
            pass_lbl.Visible = false;
           

            //#########################3
            student_obj = new Student(); 
            student_obj.load();

            doctor_obj = new Doctor();
           doctor_obj.load();
            Officer_obj = new Officer();
           Officer_obj.load(); 


        }

      

        private void dean_btn_Click(object sender, EventArgs e)
        { 
            // Edit components
            doc_btn.Visible = false;
            student_btn.Visible = false;
            officer_btn.Visible = false;
            dean = true;
            log_btn.Visible = true;
            register_btn.Visible = false;
            Student_Affairs_Officer_btn.Visible = false;
            // ################################

        }
        private void Student_Affairs_Officer_btn_Click(object sender, EventArgs e)
        {
            // Edit components
            doc_btn.Visible = false;
            student_btn.Visible = false;
            officer_btn.Visible = false;
            Student_Affairs_Officer = true;
            log_btn.Visible = true;
            register_btn.Visible = false;
            // ################################

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            // Edit components
            label1.Visible = true;
            label1.Text = "Dean";
            doc_btn.Visible = false;
            student_btn.Visible = false;
            officer_btn.Visible = false;
            dean = true;
            dean_btn.Visible = false; 
            log_btn.Visible = true;
            register_btn.Visible = false;
            Student_Affairs_Officer_btn.Visible = false;
            // ################################
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Edit components
            label1.Visible = true;
            doc_btn.Visible = false;
            Student_Affairs_Officer_btn.Visible = false;
            label1.Text = "Student_Affairs_Officer";
            student_btn.Visible = false;
            officer_btn.Visible = false;
            Student_Affairs_Officer = true;
            log_btn.Visible = true;
            register_btn.Visible = false;
            dean_btn.Visible = false;
            Student_Affairs_Officer = true; 
            // ################################
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // Edit components
            label1.Visible = true;
            doc_btn.Visible = false;
            label1.Text = "Doctor";
            dean_btn.Visible = false;
            student_btn.Visible = false;
            officer_btn.Visible = false;
            doctor = true;
            log_btn.Visible = true;
            register_btn.Visible = true;
            Student_Affairs_Officer_btn.Visible = false;
            // ##############################################
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // Edit components
            label1.Visible = true;
            officer_btn.Visible = false;
            label1.Text = "Officer";
            doc_btn.Visible = false;
            student_btn.Visible = false;
            dean_btn.Visible = false;
            officer = true;
            log_btn.Visible = true;
            register_btn.Visible = true;
            Student_Affairs_Officer_btn.Visible = false;
            // ##############################################
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // Edit components
            label1.Visible = true;
            student_btn.Visible = false;
            label1.Text = "Student";
            doc_btn.Visible = false;
            officer_btn.Visible = false;
            dean_btn.Visible = false;
            student = true;
            log_btn.Visible = true;
            register_btn.Visible = true;
            Student_Affairs_Officer_btn.Visible = false;
            // ##############################################
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            // Edit Components 
            mail_txt.Visible = true;
            password_txt.Visible = true;
            mail_lbl.Visible = true;
            pass_lbl.Visible = true;
            login = true;
            register = false;
            ok_btn.Visible = true;
            log_btn.Visible = false;
            register_btn.Visible = false;
            mail_txt.Text = "";
            password_txt.Text = "";
            // ##############################################
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //Edit components
            mail_txt.Visible = true;
            password_txt.Visible = true;
            mail_lbl.Visible = true;
            pass_lbl.Visible = true;
            register = true;
            login = false;
            ok_btn.Visible = true;
            log_btn.Visible = false;
            register_btn.Visible = false;
            // ##############################################
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (mail_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("Enter Your name and Password ");
                return;
            }
            string mail_tmp = mail_txt.Text.ToString();
            string pass_tmp = password_txt.Text.ToString();

            // four cases . each case represent one type of user .. 
            // in each case .. have tow cases (Login or Register ) .. 
            if (dean)
            {
                
                if (login)
                {
               
                    if (mail_txt.Text == "Wael" && password_txt.Text == "2514")
                    {
                        Dean_form dean_form_obj = new Dean_form();
                        dean_form_obj.Show();
                    }
                    else
                        MessageBox.Show("Invalid Dean Account ");
                }

            }
            else if (Student_Affairs_Officer)
            {
             
                if (mail_tmp == "Wael" && pass_tmp == "2514")
                {
                    Student_Affairs_Officer_formcs SAO_form_obj = new Student_Affairs_Officer_formcs();
                    SAO_form_obj.Show();
                }
                else
                    MessageBox.Show("Invalid Student Affairs Officer Account ");

            }
            else if (doctor)
            {
               
                if (login)
                {
                   
                    if (doctor_obj.Check_Login(mail_tmp, pass_tmp))
                    {
                        Doctor_form doc_form = new Doctor_form(mail_tmp);
                        doc_form.Show();
                    }
                    else
                        MessageBox.Show("Wrong Mail Or Password ");

                }

                else if (register)
                {
                   

                    if (!(doctor_obj.Exist(mail_tmp)))
                    {
                        doctor_obj.set_values(mail_tmp, pass_tmp);

                        doctor_obj.Doctors.Add(doctor_obj);
                        doctor_obj.Save();
                        MessageBox.Show("Done Register Successfuly ");
                    }
                    else
                        MessageBox.Show("Mail Already Exist");
                    mail_txt.Text = "";
                    password_txt.Text = "";
                }
            }

            else if (officer)
            {
               
                if (login)
                {
                   

                    if (Officer_obj.Check_Login(mail_tmp, pass_tmp))
                    {
                        Officer_form obj_form = new Officer_form(mail_tmp);
                        obj_form.Show();
                    }
                    else
                        MessageBox.Show("Wrong Mail Or Password ");
                }
                else if (register)
                {
                    

                    if (!(Officer_obj.Exist(mail_tmp)))
                    {
                        Officer_obj.set_values(mail_tmp, pass_tmp);
                        Officer_obj.Officers.Add(Officer_obj);
                        Officer_obj.Save();
                        MessageBox.Show("Done Register Successfuly ");
                    }
                    else
                        MessageBox.Show("Mail Already Exist");
                    mail_txt.Text = "";
                    password_txt.Text = "";
                }
            }

            else if (student)
            {
             

                if (login)
                {
                    
                    if (student_obj.Check_Login(mail_tmp, pass_tmp))
                    {
                        Student_form st_form = new Student_form(mail_tmp);
                        st_form.Show();
                    }

                    else
                        MessageBox.Show("Wrong Mail Or Password ");

                }
                else if (register)
                {
                   
                    if (!(student_obj.Exist(mail_tmp)))
                    {
                        student_obj.set_values(mail_tmp, pass_tmp);

                        student_obj.students.Add(student_obj);
                        student_obj.Save();
                        MessageBox.Show("Done Register Successfuly ");
                    }
                    else
                        MessageBox.Show("Mail Already Exist");
                    mail_txt.Text = "";
                    password_txt.Text = "";
                }
            
        }
    }

        private void mail_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            dean = student = officer = doctor = login = register = Student_Affairs_Officer = false;

            dean_btn.Visible = true;
            student_btn.Visible = true;
            officer_btn.Visible = true;
            doc_btn.Visible = true;
            Student_Affairs_Officer_btn.Visible = true;
            label1.Text = "";
            mail_txt.Visible = false;
            password_txt.Visible = false;
            ok_btn.Visible = false;
            mail_lbl.Visible = false;
            pass_lbl.Visible = false;
            log_btn.Visible = false;
            register_btn.Visible = false;

        }

        private void doc_btn_Click(object sender, EventArgs e)
        {
            // Edit components
            dean_btn.Visible = false;
            student_btn.Visible = false;
            officer_btn.Visible = false;
            doctor = true;
            log_btn.Visible = true;
            register_btn.Visible = true;
            Student_Affairs_Officer_btn.Visible = false;
            // ##############################################
        }

       

        private void officer_btn_Click(object sender, EventArgs e)
        {
            // Edit components
            doc_btn.Visible = false;
            student_btn.Visible = false;
            dean_btn.Visible = false;
            officer = true;
            log_btn.Visible = true;
            register_btn.Visible = true;
            Student_Affairs_Officer_btn.Visible = false;
            // ##############################################

        }

        private void student_btn_Click(object sender, EventArgs e)
        {
            // Edit components
            doc_btn.Visible = false;
            officer_btn.Visible = false;
            dean_btn.Visible = false;
            student = true;
            log_btn.Visible = true;
            register_btn.Visible = true;
            Student_Affairs_Officer_btn.Visible = false;
            // ##############################################



        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            // Edit components
           
            mail_txt.Visible = true;
            password_txt.Visible = true;
            mail_lbl.Visible = true;
            pass_lbl.Visible = true;
            register = true;
            login = false; 
            ok_btn.Visible = true; 
            // ##############################################

        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            // Edit Components 
            mail_txt.Visible = true;
            password_txt.Visible = true;
            mail_lbl.Visible = true;
            pass_lbl.Visible = true;
            login = true;
            register = false; 
            ok_btn.Visible = true;
            // ##############################################
        }
        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (mail_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("Enter Your name and Password ");
                return;
            }
            string mail_tmp = mail_txt.Text.ToString();
            string pass_tmp = password_txt.Text.ToString();

            // four cases . each case represent one type of user .. 
            // in each case .. have tow cases (Login or Register ) .. 
            if (dean)
            {
                if (login)
                {
                    if (mail_txt.Text == "asmaa" && password_txt.Text == "1234")
                    {
                        Dean_form dean_form_obj = new Dean_form();
                        dean_form_obj.Show();
                    }
                    else
                        MessageBox.Show("Invalid Dean Account ");
                }
               
            }
            else if (Student_Affairs_Officer)
            {
                if (mail_tmp == "Wael" && pass_tmp == "2514")
                {
                    Student_Affairs_Officer_formcs SAO_form_obj = new Student_Affairs_Officer_formcs();
                    SAO_form_obj.Show();
                }
                else
                    MessageBox.Show("Invalid Dean Account ");

            }
            else if (doctor)
            {

                if (login)
                {

                    if (doctor_obj.Check_Login(mail_tmp, pass_tmp))
                    {
                        Doctor_form doc_form = new Doctor_form(mail_tmp);
                        doc_form.Show();
                    }
                    else
                        MessageBox.Show("Wrong Mail Or Password ");

                }
                
                else if (register)
                {

                    if (!(doctor_obj.Exist(mail_tmp)))
                    {
                        doctor_obj.set_values(mail_tmp, pass_tmp);

                        doctor_obj.Doctors.Add(doctor_obj);
                        doctor_obj.Save();
                        MessageBox.Show("Done Register Successfuly ");
                    }
                    else
                        MessageBox.Show("Mail Already Exist");
                    mail_txt.Text = "";
                    password_txt.Text = "";
                }
            }

            else if (officer)
            {

                if (login)
                {

                    if (Officer_obj.Check_Login(mail_tmp, pass_tmp))
                    {
                        Officer_form obj_form = new Officer_form(mail_tmp);
                        obj_form.Show();
                    }
                    else
                        MessageBox.Show("Wrong Mail Or Password ");
                }
                else if (register)
                {

                    if (!(Officer_obj.Exist(mail_tmp)))
                    {
                        Officer_obj.set_values(mail_tmp, pass_tmp);
                        Officer_obj.Officers.Add(Officer_obj);
                        Officer_obj.Save();
                        MessageBox.Show("Done Register Successfuly ");
                    }
                    else
                        MessageBox.Show("Mail Already Exist");
                    mail_txt.Text = "";
                    password_txt.Text = "";
                }
            }

            else if (student)
            {


                if (login)
                {

                    if (student_obj.Check_Login(mail_tmp, pass_tmp))
                    {
                        Student_form st_form = new Student_form(mail_tmp);
                        st_form.Show();
                    }

                    else
                        MessageBox.Show("Wrong Mail Or Password ");

                }
                else if (register)
                {
                    if (!(student_obj.Exist(mail_tmp)))
                    {
                        student_obj.set_values(mail_tmp, pass_tmp);

                        student_obj.students.Add(student_obj);
                        student_obj.Save();
                        MessageBox.Show("Done Register Successfuly ");
                    }
                    else
                        MessageBox.Show("Mail Already Exist");
                    mail_txt.Text = "";
                    password_txt.Text = "";
                }
            }
            }





//////////////////////////////////////////////////////////////////////////////////////////
        }
    }

