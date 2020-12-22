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
    public partial class UserManagement : Form
    {
        int id = 0;
        int eid = 0;
        Home home;
        string message;
        public UserManagement(Home home,string message)
        {
            this.message = message;
            this.home = home;
            InitializeComponent();
           // addUserButton.Click += this.RefreshGridView;
          //  addUserButton.Click += this.ClearFields;
            updateEventButton.Click += this.RefreshGridView;
            updateEventButton.Click += this.ClearFields;
            deleteEventButton.Click += this.RefreshGridView;
            deleteEventButton.Click += this.ClearFields;
        }

        private void UserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
           // loadUserDataGridView.DataSource = userService.GetListOfUsers();
           // userService = new UserService();
          //  userWiseEventComboBox.DataSource = userService.GetUserNameList();
          //  userService = new UserService();
            loadListOfEventsGridView.DataSource = userService.GetEventListByUser(message);

        }
        void RefreshGridView(object sender, EventArgs e)
        {
            UserService userService = new UserService();
           // loadUserDataGridView.DataSource = userService.GetListOfUsers();
           // userService = new UserService();
          //  userWiseEventComboBox.DataSource = userService.GetUserNameList();
          //  userService = new UserService();
            loadListOfEventsGridView.DataSource = userService.GetEventListByUser(message);
        }
        void ClearFields(object sender, EventArgs e)
        {
            updateEventTitleTextBox.Text=deleteEventTitleTextBox.Text=updateEventDescriptionTextBox.Text= string.Empty;

        }

        //private void addUserButton_Click(object sender, EventArgs e)
       // {
        //    UserService userService = new UserService();
        //    int result = userService.AddNewUser(addUserNameTextBox.Text);
        //    if(result > 0)
        //    {
        //        MessageBox.Show("User added successfully");
       //     }
        //    else
        //    {
         //       MessageBox.Show("Error adding category");
         //   }
      //  }

        private void loadListOfEventsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)loadListOfEventsGridView.Rows[e.RowIndex].Cells[0].Value;
            updateEventTitleTextBox.Text = loadListOfEventsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            updateEventDescriptionTextBox.Text = loadListOfEventsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.UpdateEvent(id,updateEventTitleTextBox.Text,updateEventLastDateTimePicker.Text,updateEventDescriptionTextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Event updated successfully");
            }
            else
            {
                MessageBox.Show("Error updating Event");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            
            //UserService userService = new UserService();
            //int result = userService.DeleteUser(deleteEventTitleTextBox.Text);
            //if (result > 0)
            //{
            //   MessageBox.Show("User deleted successfully");
            //}
            //else
            //{
            //  MessageBox.Show("Error deleting user");
            //}
        }

        //private void userWiseEventComboBox_SelectedIndexChanged(object sender, EventArgs e)
       // {
       //     UserService userService = new UserService();
       //     SearchEventByImportanceDataGridView.DataSource = userService.GetEventListByUser(userWiseEventComboBox.Text);
      //  }


        private void button1_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        private void updateUserButton_Click_1(object sender, EventArgs e)
        {

        }

        private void SearchEventByImportanceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            SearchEventByImportanceDataGridView.DataSource = eventService.GetEventListSearchByImpotance(message, SearchEventByImportanceComboBox.Text);
        }

        private void SearchEventByImportanceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eid = (int)SearchEventByImportanceDataGridView.Rows[e.RowIndex].Cells[0].Value;
            deleteEventTitleTextBox.Text = SearchEventByImportanceDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.DeleteEvent(eid.ToString());
            if (result > 0)
            {
               MessageBox.Show("Event deleted successfully");
            }
            else
            {
              MessageBox.Show("Error deleting Event");
            }
        }
    }
}
