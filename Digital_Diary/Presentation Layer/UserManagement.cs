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
        Home home;
        public UserManagement(Home home)
        {
            this.home = home;
            InitializeComponent();
            addUserButton.Click += this.RefreshGridView;
            addUserButton.Click += this.ClearFields;
            updateUserButton.Click += this.RefreshGridView;
            updateUserButton.Click += this.ClearFields;
            deleteUserButton.Click += this.RefreshGridView;
            deleteUserButton.Click += this.ClearFields;
        }

        private void UserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            loadUserDataGridView.DataSource = userService.GetListOfUsers();
            userService = new UserService();
            userWiseEventComboBox.DataSource = userService.GetUserNameList();
        }
        void RefreshGridView(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            loadUserDataGridView.DataSource = userService.GetListOfUsers();
            userService = new UserService();
            userWiseEventComboBox.DataSource = userService.GetUserNameList();
        }
        void ClearFields(object sender, EventArgs e)
        {
            addUserNameTextBox.Text = updateUserNameTextBox.Text=deleteUserIdTextBox.Text= string.Empty;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            int result = userService.AddNewUser(addUserNameTextBox.Text);
            if(result > 0)
            {
                MessageBox.Show("User added successfully");
            }
            else
            {
                MessageBox.Show("Error adding category");
            }
        }

        private void loadUserDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id=(int)loadUserDataGridView.Rows[e.RowIndex].Cells[0].Value;
            updateUserNameTextBox.Text = loadUserDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            int result = userService.UpdateUser(id,updateUserNameTextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("User updated successfully");
            }
            else
            {
                MessageBox.Show("Error updating user");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            int result = userService.DeleteUser(deleteUserIdTextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("User deleted successfully");
            }
            else
            {
                MessageBox.Show("Error deleting user");
            }
        }

        private void userWiseEventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            userWiseEventDataGridView.DataSource = userService.GetEventListByUser(userWiseEventComboBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }
    }
}
