using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;

namespace Problems_Tracking_Sys
{
 public   class Officer
    {
        public string mail;
        public string password;
        public List<string> complaints;
        public List<string> Replaies;

        [XmlIgnore]
        public List<Officer> Officers;

        public Officer()
        {
            complaints = new List<string>();
            Replaies = new List<string>();

            Officers = new List<Officer>();

        }
        public void set_values(string paramMail, string pass)
        {
            this.mail = paramMail;
            this.password = pass;

        }
        public bool Set_Replay(string Officer_mail, string complaint, string reply)
        {
            for (int i = 0; i < Officers.Count; i++)
            {
                if (Officers[i].mail == Officer_mail)
                {
                    for (int j = 0; j < Officers[i].complaints.Count; j++)
                    {
                        if (Officers[i].complaints[j] == complaint)
                        {
                            Officers[i].Replaies[j] = reply;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool Check_Login(string param_mail, string pass)
        {

            for (int i = 0; i < this.Officers.Count; i++)
            {
                if (Officers[i].mail == param_mail && Officers[i].password == pass)
                    return true;
            }
            return false;
        }

        public bool Exist(string mail)
        {
            for (int i = 0; i < this.Officers.Count; i++)
            {
                if (Officers[i].mail == mail)
                    return true;
            }
            return false;
        }


        public string view(string mail)
        {
            string all = "No Complaints Exist \n ";

            for (int i = 0; i < Officers.Count; i++)
            {
                if (Officers[i].mail == mail)
                {
                    all = "Your Complaints And Replaies \n ";
                    for (int j = 0; j < Officers[i].complaints.Count; j++)
                    {
                        all += Officers[i].complaints[j];
                        all += "\n Replay :- \n ";
                        all += Officers[i].Replaies[j];
                        all += "\n";
                    }
                    all += " ************ Problem Tracking System ************ \n ";
                }
            }
            return all;
        }
        public void Add_Complaints(string mail, string complaint)
        {
            for (int i = 0; i < Officers.Count; i++)
            {
                if (Officers[i].mail == mail)
                {
                    Officers[i].complaints.Add(complaint);
                    Officers[i].Replaies.Add("This complaint has not yet been Replaied ");

                }
            }
        }
        public void load()
        {
            FileStream fs = new FileStream("Officers.xml", FileMode.OpenOrCreate);
            XmlSerializer se = new XmlSerializer(Officers.GetType());
            Officers = (List<Officer>)se.Deserialize(fs);
            fs.Close();


        }
        public void Save()
        {
            FileStream fs = new FileStream("Officers.xml", FileMode.Truncate);
            XmlSerializer se = new XmlSerializer(Officers.GetType());
            se.Serialize(fs, Officers);
            fs.Close();
        }

    }
}
