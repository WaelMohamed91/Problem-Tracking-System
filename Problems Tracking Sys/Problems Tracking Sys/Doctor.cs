using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Problems_Tracking_Sys
{
  public  class Doctor
    {
        public string mail;
        public string password;
        public List<string> complaints;
        public List<string> Replaies;

        [XmlIgnore]
        public List<Doctor> Doctors ;
       public Doctor ()
        {
            complaints = new List<string>();
            Replaies = new List<string>();

            Doctors = new List<Doctor>(); 

        }
        public void set_values(string paramMail, string pass)
        {
            this.mail = paramMail;
            this.password = pass;
          
        }
        public bool Check_Login(string param_mail, string pass)
        {

            for (int i = 0; i < this.Doctors.Count; i++)
            {
                if (Doctors[i].mail == param_mail && Doctors[i].password == pass)
                    return true;
            }
            return false;
        }
        public string view(string mail)
        {
            string all = "No Complaints Exist \n ";

            for (int i = 0; i < Doctors.Count; i++)
            {
                if (Doctors[i].mail == mail)
                {
                    all = "Your Complaints And Replaies \n ";
                    for (int j = 0; j < Doctors[i].complaints.Count; j++)
                    {
                        all += Doctors[i].complaints[j];
                        all += "\n Replay :- \n ";
                        all += Doctors[i].Replaies[j];
                        all += "\n";
                    }
                    all += "\n  ************ Problem Tracking System ************ \n ";
                }
            }
            return all;
        }

        public bool Exist(string mail)
        {
            for (int i = 0; i < this.Doctors.Count; i++)
            {
                if (Doctors[i].mail == mail)
                    return true;
            }
            return false; 
        }
        public void Add_Complaints (string mail , string complaint )
        {
            for (int i = 0; i <Doctors.Count; i ++)
            {
                if (Doctors[i].mail == mail )
                {
                    Doctors[i].complaints.Add(complaint);
                    Doctors[i].Replaies.Add("This complaint has not yet been Replaied "); 

                }
            }
        }
        public bool Set_Replay(string student_mail, string complaint, string reply)
        {
            for (int i = 0; i < Doctors.Count; i++)
            {
                if (Doctors[i].mail == student_mail)
                {
                    for (int j = 0; j < Doctors[i].complaints.Count; j++)
                    {
                        if (Doctors[i].complaints[j] == complaint)
                        {
                            Doctors[i].Replaies[j] = reply;
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        public void load()
        {
            FileStream fs = new FileStream("Doctors.xml", FileMode.OpenOrCreate);
            XmlSerializer se = new XmlSerializer(Doctors.GetType());
            Doctors = (List<Doctor>)se.Deserialize(fs);
            fs.Close();
        }
        public void Save()
        {
            FileStream fs = new FileStream("Doctors.xml", FileMode.Truncate);
            XmlSerializer se = new XmlSerializer(Doctors.GetType());
            se.Serialize(fs, Doctors);
            fs.Close();
        }


    }

}
