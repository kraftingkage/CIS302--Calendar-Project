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

            DateTime today = DateTime.Today;
            DateTime d = DateTime.Today;
            int z = 0;
            while (d != today.AddDays(7))
            {
                switch (z)
                {
                    case 0:
                        todayDate.Text = d.ToShortDateString();
                        todayTitle.Text = d.DayOfWeek.ToString();
                        break;
                    case 1:
                        p1Date.Text = d.ToShortDateString();
                        p1Title.Text = d.DayOfWeek.ToString();
                        break;
                    case 2:
                        p2Date.Text = d.ToShortDateString();
                        p2Title.Text = d.DayOfWeek.ToString();
                        break;
                    case 3:
                        p3Date.Text = d.ToShortDateString();
                        p3Title.Text = d.DayOfWeek.ToString();
                        break;
                    case 4:
                        p4Date.Text = d.ToShortDateString();
                        p4Title.Text = d.DayOfWeek.ToString();
                        break;
                    case 5:
                        p5Date.Text = d.ToShortDateString();
                        p5Title.Text = d.DayOfWeek.ToString();
                        break;
                    case 6:
                        p6Date.Text = d.ToShortDateString();
                        p6Title.Text = d.DayOfWeek.ToString();
                        break;
                }
                z++;
                d = d.AddDays(1);
            }
            //UserControl1 event1 = new UserControl1();
            //panel1.Controls.Add(event1);

            for(int i = 1; i < 24; i++)
            {
                UserControl1 event1 = new UserControl1(i.ToString());
                panelSun.Controls.Add(event1);
            }

        }
            
    }
}

