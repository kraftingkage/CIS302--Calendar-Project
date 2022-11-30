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
using System.Media;
using Calendar_Project;

namespace Calendar_Project
{
    public partial class Form1 : Form
    {

        #region InitArea
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calendar Project";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if(!File.Exists("usersettings.ini"))
            {
                MessageBox.Show("User Settings file not detected... Initiating setup.");
                UserCreator f = new UserCreator();
                f.ShowDialog();
                initSettings();
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
            var data = reader.ReadLine();
            var filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CIS302CalendarKAC/appointments");
            EventHandler(filepath);
            while (data != null)
            {
                if (data.StartsWith("Name:"))
                {
                    string name = data.Replace("Name: ", "");
                    label1.Text = "Welcome,\n" + name;
                }
                data = reader.ReadLine();
            }
            reader.Close();

            /*
             * Grabs the next sunday, and then finds previous sunday. NOTE: May find way to just find previous sunday, but this works without pain.
             * As it stands... 'nextSun' variable find the next sunday. EG... Today is Saturday 10/29/22.. It will find Sunday 10/30/22 (as this would be the first day of next week)
             * then, 'target' is the PREVIOUS Sunday, as it is the start of the CURRENT week.
             */
            DateTime nextSun = Extension.Next(DateTime.Now, DayOfWeek.Sunday);
            DateTime target = nextSun.AddDays(-7);

            int z = 0;


            //Sets the days to the correct date and day of week
            while (target != nextSun.AddDays(7))
            {
                //This switch is over-enginered... however it was good experience and it works with minimal issue.
                
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

        }

        #endregion
        #region Event Handler

        //Adds events to calendar 
        public void EventHandler(string filepath)
        {

            //NOTE TO SELF, THEY NEED TO BE IN 24 HR FORMAT TO MAKE SENSE TO COMPUTER PLZ
            string[] events = Directory.GetFiles(filepath);
            //Copy from above, gives me next sunday, and last sunday.
            DateTime nextSun = Extension.Next(DateTime.Now.Date, DayOfWeek.Sunday);
            DateTime target = nextSun.AddDays(-7);


            //start by clearing all events
            panelSun.Controls.Clear();
            panelMon.Controls.Clear();
            panelTues.Controls.Clear();
            panelWed.Controls.Clear();
            panelThurs.Controls.Clear();
            panelFri.Controls.Clear();
            panelSat.Controls.Clear();

            foreach (string e in events)
            {
                //converts filepath to be just file name
                string filename = e.Replace($"{filepath}\\", "");
                string parse = filename.Replace(".ini", "");
                //converts filename to datetime for comparison
                DateTime check = DateTime.ParseExact(parse, "yyyyMMddHHmm", null);


                //Check if the file's data is within the calendar range, if it is before, delete the record as it is no longer needed (for space reasons.)
                if(check < target)
                {
                    File.Delete(e);
                }else if(check > target & check < nextSun)
                {
                    StreamReader r = new StreamReader(e);
                    var data = r.ReadLine();
                    string apptTitle = data;
                    data = r.ReadLine();
                    DateTime apptDate = DateTime.Parse(data);
                    data = r.ReadLine();
                    string apptLocation = data.ToString();
                    data = r.ReadLine();
                    string apptRequired = data.ToString();
                    data = r.ReadLine();
                    string apptOptional = data.ToString();
                    data = r.ReadLine();
                    string apptNotes = data.ToString();
                    data = r.ReadLine();
                    while (data != null)
                    {
                        apptNotes += "\n" + data.ToString();
                        data = r.ReadLine();
                    }
                    data = r.ReadLine();
                    r.Close();

                    data = null;


                    string day = apptDate.DayOfWeek.ToString();

                    eventControl event1 = new eventControl(apptTitle, apptDate, apptLocation, apptRequired, apptOptional, apptNotes);

                    //this switch sets the event into the correct day of the week
                    switch (day)
                    {
                        case "Sunday":
                            panelSun.Controls.Add(event1);
                            break;
                        case "Monday":
                            panelMon.Controls.Add(event1);
                            break;
                        case "Tuesday":
                            panelTues.Controls.Add(event1);
                            break;
                        case "Wednesday":
                            panelWed.Controls.Add(event1);
                            break;
                        case "Thursday":
                            panelThurs.Controls.Add(event1);
                            break;
                        case "Friday":
                            panelFri.Controls.Add(event1);
                            break;
                        case "Saturday":
                            panelSat.Controls.Add(event1);
                            break;
                    }
                        
                }
            }
                


        }

        #endregion
        #region Sidebar
        //SIDEBAR SECTION ==================================================================================================================================================
        bool sidebarExpand;
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //If sidebar is expanded, minimise it.
                sidebar.Width -= 5;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }else
            {
                sidebar.Width += 5;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {         
                    sidebarExpand = true;
                    sidebarTimer.Stop();
            }
            }

            
        }
        #endregion
        #region Buttons

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarTimer.Start();
            }
            else
            {
                SystemSounds.Asterisk.Play();
            }
        }
        private void newApptButton_Click(object sender, EventArgs e)
        {
            AppointmentCreator f = new AppointmentCreator("create");
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            initSettings();
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm f = new SettingsForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To create a new appointment for your calendar, please open the menu and click 'Add Appointment'. After your appointment is created, refresh the calendar and your appointment will appear.");
        }
        #endregion
    }
}


