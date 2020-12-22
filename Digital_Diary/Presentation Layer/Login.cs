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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text== "" || passwordTextBox.Text== "")
            {
                MessageBox.Show("Username or password can not be empty");
            }
            else
            {
                UserService userService = new UserService();
                bool result = userService.LginValidation(usernameTextBox.Text, passwordTextBox.Text);
                if(result)
                {
                    Home home = new Home(usernameTextBox.Text);
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password ");
                }
            }
        }
    }
}
