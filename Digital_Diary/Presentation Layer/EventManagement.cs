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
        public EventManagement(Home home)
        {
            this.home = home;
            InitializeComponent();
            addEventButton.Click += this.RefreshGridView;
        }
        private void EventManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EventManagement_Load(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            loadEentListGridView.DataSource = eventService.GetEventList();
            UserService userService = new UserService();
            addEventUserComboBox.DataSource = userService.GetUserNameList();
        }
        void RefreshGridView(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            loadEentListGridView.DataSource = eventService.GetEventList();
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.AddNewEvent(addEventTitleTextBox.Text,addEventDateTimePicker.Text,addEventDescriptionTextBox.Text,addEventImportanceComboBox.Text,addEventUserComboBox.Text);
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
            searchEventGridView.DataSource = eventService.GetEventListForSearch(SearchEventTitleTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }
    }
}
