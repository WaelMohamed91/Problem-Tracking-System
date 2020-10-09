using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Problems_Tracking_Sys
{

   public class Student
    {
      public  string mail;
        public string password; 

         public  List<string> complaints_ToDotctors ;
        public List<string> Replaies_From_Doctors ;
        public List<string> complaints_ToOfficers ;
        public List<string> Replaies_From_Officers;




        [XmlIgnore]
         public List<Student> students;
         
       public Student ()
        {
            complaints_ToDotctors = new List<string>();
            Replaies_From_Doctors = new List<string>();
            complaints_ToOfficers = new List<string>();
            Replaies_From_Officers = new List<string>();


            students = new List<Student>();
           

        }
        public  void set_values (string paramMail , string pass )
        {
            this.mail = paramMail;
            this.password = pass;
           
        }
        public bool  Check_Login (string param_mail , string pass )
        {

            for (int i = 0; i < this.students.Count; i++)
            {
                if (students[i].mail == param_mail && students[i].password == pass)
                    return true;
            }
            return false; 
        } 
        public bool Exist (string mail)
        {
          for (int i = 0; i < this.students.Count; i++)
            {
                if (students[i].mail == mail)
                    return true;
            }
          
            return false  ; 
        }
        public string View_ComplaintsWith_Replaies  (string mail )
        {
            string all = "No Complaints Exist \n " ;
            for (int i =0; i < students.Count; i ++)
            {
                if (students[i].mail == mail )
                {
                    all = "Complaints To Doctors ... \n "; 
                    for (int j = 0; j < students[i].complaints_ToDotctors.Count ; j ++)
                    {
                        all += students[i].complaints_ToDotctors[j];
                        all += "\n Replay  :- \n  "; 
                        all += students[i].Replaies_From_Doctors[j];
                        all += "\n";  
                    }
                    all += "\n Complaints To Offcers  ... \n";
                    for (int j = 0; j < students[i].complaints_ToOfficers.Count; j++)
                    {
                        all += students[i].complaints_ToOfficers[j];
                        all += "\n Replay  :- \n  ";
                        all += students[i].Replaies_From_Officers[j];
                        all += "\n";
                    }
                    all += "\n"; 
                    all += " ************ Problem Tracking System ************ \n "; 
                }
            }
            return all; 
            
        }
        public void Add_Complaint_ToDoctor (string mail , string complaint )
        {
            for (int i = 0;  i < students.Count; i ++ )
            {
                if (students[i].mail == mail )
                {
                    students[i].complaints_ToDotctors.Add(complaint);
                    students[i].Replaies_From_Doctors.Add("This complaint has not yet been Replaied "); 

                }
            }
        }
        public void Add_Complaint_ToOfficer (string mail, string complaint)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].mail == mail)
                {
                    students[i].complaints_ToOfficers.Add(complaint);
                    students[i].Replaies_From_Officers.Add("This complaint has not yet been Replaied ");

                }
            }

        }
        public bool Set_Replay_from_doctor  (string student_mail , string complaint , string reply)
        {
            for (int i = 0; i <students.Count; i++)
            {
                if (students[i].mail == student_mail)
                {
                    for (int j = 0; j< students[i].complaints_ToDotctors.Count; j++)
                    {
                        if (students[i].complaints_ToDotctors[j] == complaint)
                        {
                            students[i].Replaies_From_Doctors[j] = reply;
                            return true; 
                        }
                    }
                }
            }
            return false; 
        }
        public bool Set_Replay_from_Officer(string student_mail, string complaint, string reply)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].mail == student_mail)
                {
                    for (int j = 0; j < students[i].complaints_ToOfficers.Count; j++)
                    {
                        if (students[i].complaints_ToOfficers[j] == complaint)
                        {
                            students[i].Replaies_From_Officers[j] = reply;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public void load ()
        {
            FileStream fs = new FileStream("Studens.xml", FileMode.OpenOrCreate);
            XmlSerializer se = new XmlSerializer(students.GetType());
            students = (List<Student>)se.Deserialize(fs);
            fs.Close();
        }
        public void Save ()
        {
            FileStream fs = new FileStream("Studens.xml", FileMode.Truncate);
            XmlSerializer se = new XmlSerializer(students.GetType());
            se.Serialize(fs, students);
            fs.Close();
        }



         

    }
}
