using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Calendar_Project;

namespace Calendar_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("usersettings.ini"))
            {
                MessageBox.Show("User Settings file not detected... Initiating setup.");
                UserCreator f = new UserCreator();
                f.Show();
            }
            else
            {
                initSettings();
            }

        }

        //Setting all labels with their corresponding days/names
        private void initSettings()
        {
            StreamReader reader = new StreamReader("usersettings.ini");
            string data = reader.ReadLine();

            while(data != null)
            {
                if (data.StartsWith("Name:"))
                {
                    string name = data.Replace("Name: ", "");
                    label1.Text = "Welcome,\n" + name;
                }
                data = reader.ReadLine();
                }

            /*
             * Grabs the next sunday, and then finds previous sunday. NOTE: May find way to just find previous sunday, but this works without pain.
             * As it stands... 'nextSun' variable find the next sunday. EG... Today is Saturday 10/29/22.. It will find Sunday 10/30/22 (as this would be the first day of next week)
             * then, 'target' is the PREVIOUS Sunday, as it is the start of the CURRENT week.
             */
            DateTime nextSun = Extension.Next(DateTime.Now, DayOfWeek.Sunday);
            DateTime target = nextSun.AddDays(-7);

            int z = 0;
            
            while (target != nextSun.AddDays(7))
            {
                switch (z)
                {
                    case 0:
                        todayDate.Text = target.ToShortDateString();
                        todayTitle.Text = target.DayOfWeek.ToString();
                        break;
                    case 1:
                        p1Date.Text = target.ToShortDateString();
                        p1Title.Text = target.DayOfWeek.ToString();
                        break;
                    case 2:
                        p2Date.Text = target.ToShortDateString();
                        p2Title.Text = target.DayOfWeek.ToString();
                        break;
                    case 3:
                        p3Date.Text = target.ToShortDateString();
                        p3Title.Text = target.DayOfWeek.ToString();
                        break;
                    case 4:
                        p4Date.Text = target.ToShortDateString();
                        p4Title.Text = target.DayOfWeek.ToString();
                        break;
                    case 5:
                        p5Date.Text = target.ToShortDateString();
                        p5Title.Text = target.DayOfWeek.ToString();
                        break;
                    case 6:
                        p6Date.Text = target.ToShortDateString();
                        p6Title.Text = target.DayOfWeek.ToString();
                        break;
                }
                z++;
                target = target.AddDays(1);
            }
            


            //Example of event controller
            for(int i = 1; i < 24; i++)
            {
                UserControl1 event1 = new UserControl1(i.ToString());
                panelSun.Controls.Add(event1);
            }

        }


    }
}

