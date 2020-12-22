namespace Digital_Diary.Presentation_Layer
{
    partial class UserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadUserDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.addUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.updateUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.deleteUserIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.userWiseEventDataGridView = new System.Windows.Forms.DataGridView();
            this.userWiseEventComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadUserDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userWiseEventDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadUserDataGridView
            // 
            this.loadUserDataGridView.AllowUserToAddRows = false;
            this.loadUserDataGridView.AllowUserToDeleteRows = false;
            this.loadUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadUserDataGridView.Location = new System.Drawing.Point(513, 21);
            this.loadUserDataGridView.Name = "loadUserDataGridView";
            this.loadUserDataGridView.ReadOnly = true;
            this.loadUserDataGridView.Size = new System.Drawing.Size(275, 127);
            this.loadUserDataGridView.TabIndex = 0;
            this.loadUserDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadUserDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Users";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addUserButton);
            this.groupBox1.Controls.Add(this.addUserNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New User";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(114, 55);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(166, 30);
            this.addUserButton.TabIndex = 3;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // addUserNameTextBox
            // 
            this.addUserNameTextBox.Location = new System.Drawing.Point(114, 26);
            this.addUserNameTextBox.Name = "addUserNameTextBox";
            this.addUserNameTextBox.Size = new System.Drawing.Size(166, 23);
            this.addUserNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateUserButton);
            this.groupBox2.Controls.Add(this.updateUserNameTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update User";
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(114, 49);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(166, 30);
            this.updateUserButton.TabIndex = 3;
            this.updateUserButton.Text = "Update User";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // updateUserNameTextBox
            // 
            this.updateUserNameTextBox.Location = new System.Drawing.Point(114, 22);
            this.updateUserNameTextBox.Name = "updateUserNameTextBox";
            this.updateUserNameTextBox.Size = new System.Drawing.Size(166, 23);
            this.updateUserNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteUserButton);
            this.groupBox3.Controls.Add(this.deleteUserIdTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 90);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete User";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(114, 49);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(166, 30);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // deleteUserIdTextBox
            // 
            this.deleteUserIdTextBox.Location = new System.Drawing.Point(114, 22);
            this.deleteUserIdTextBox.Name = "deleteUserIdTextBox";
            this.deleteUserIdTextBox.Size = new System.Drawing.Size(166, 23);
            this.deleteUserIdTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "User ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.userWiseEventDataGridView);
            this.groupBox4.Controls.Add(this.userWiseEventComboBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(376, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 257);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User Wise Event";
            // 
            // userWiseEventDataGridView
            // 
            this.userWiseEventDataGridView.AllowUserToAddRows = false;
            this.userWiseEventDataGridView.AllowUserToDeleteRows = false;
            this.userWiseEventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userWiseEventDataGridView.Location = new System.Drawing.Point(25, 93);
            this.userWiseEventDataGridView.Name = "userWiseEventDataGridView";
            this.userWiseEventDataGridView.ReadOnly = true;
            this.userWiseEventDataGridView.Size = new System.Drawing.Size(353, 150);
            this.userWiseEventDataGridView.TabIndex = 6;
            // 
            // userWiseEventComboBox
            // 
            this.userWiseEventComboBox.FormattingEnabled = true;
            this.userWiseEventComboBox.Location = new System.Drawing.Point(137, 51);
            this.userWiseEventComboBox.Name = "userWiseEventComboBox";
            this.userWiseEventComboBox.Size = new System.Drawing.Size(144, 21);
            this.userWiseEventComboBox.TabIndex = 5;
            this.userWiseEventComboBox.SelectedIndexChanged += new System.EventHandler(this.userWiseEventComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "User Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadUserDataGridView);
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManagement_FormClosing);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadUserDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userWiseEventDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loadUserDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox addUserNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.TextBox updateUserNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.TextBox deleteUserIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView userWiseEventDataGridView;
        private System.Windows.Forms.ComboBox userWiseEventComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}