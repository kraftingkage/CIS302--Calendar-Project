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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        { 

            StreamReader reader = new StreamReader("usersettings.ini");
            var data = reader.ReadLine();
            var name = data.Replace("Name: ", "");
            textBox1.Text = name;
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete("usersettings.ini");
            StreamWriter writer = new StreamWriter("usersettings.ini");
            writer.WriteLine("Name: " + textBox1.Text);
            writer.Close();
            this.Close();
        }
    }
}
