using Digital_Diary.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Diary.Presentation_Layer
{
    public partial class EventManagement : Form
    {
        Home home;
        string message;
        public EventManagement(Home home,string message)
        {
            this.message = message;
            this.home = home;
            InitializeComponent();
            addEventButton.Click += this.RefreshGridView;
            addEventButton.Click += this.ClearFields; 
        }
        private void EventManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EventManagement_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            loadEentListGridView.DataSource = userService.GetEventListByUser(message);
            //UserService userService = new UserService();
            //addEventUserComboBox.DataSource = userService.GetUserNameList();
        }
        void RefreshGridView(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            loadEentListGridView.DataSource = userService.GetEventListByUser(message);
        }
        void ClearFields(object sender, EventArgs e)
        {
            addEventTitleTextBox.Text = addEventDescriptionTextBox.Text = addEventImportanceComboBox.Text = string.Empty;

        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.AddNewEvent(addEventTitleTextBox.Text,addEventDateTimePicker.Text,addEventDescriptionTextBox.Text,addEventImportanceComboBox.Text,message);
            if (result > 0)
            {
                MessageBox.Show("Event added successfully");
            }
            else
            {
                MessageBox.Show("Error adding Event");
            }
        }

        private void SearchEventTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            searchEventGridView.DataSource = eventService.GetEventListForSearch(message,SearchEventTitleTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }
    }
}
