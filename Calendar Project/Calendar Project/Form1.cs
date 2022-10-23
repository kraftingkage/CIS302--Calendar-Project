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
        }
    }
}
