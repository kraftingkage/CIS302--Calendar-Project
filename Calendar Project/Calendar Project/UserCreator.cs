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
    public partial class UserCreator : Form
    {
        public UserCreator()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            String name = userName.Text;
            StreamWriter writer1;

            try
            {

                writer1 = new StreamWriter("usersettings.ini");
                writer1.WriteLine("Name: "+ name);
                writer1.Close();

                //MessageBox.Show("User account has been created, closing application.");
                //Application.Exit();

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void UserCreator_Load(object sender, EventArgs e)
        {

        }
    }
}
