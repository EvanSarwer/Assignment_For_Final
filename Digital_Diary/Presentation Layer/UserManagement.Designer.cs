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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateEventLastDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.updateEventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updateEventButton = new System.Windows.Forms.Button();
            this.updateEventTitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.deleteEventTitleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SearchEventByImportanceComboBox = new System.Windows.Forms.ComboBox();
            this.SearchEventByImportanceDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loadListOfEventsGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchEventByImportanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadListOfEventsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateEventLastDateTimePicker);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.updateEventDescriptionTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.updateEventButton);
            this.groupBox2.Controls.Add(this.updateEventTitleTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 241);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Event";
            // 
            // updateEventLastDateTimePicker
            // 
            this.updateEventLastDateTimePicker.Location = new System.Drawing.Point(168, 56);
            this.updateEventLastDateTimePicker.Name = "updateEventLastDateTimePicker";
            this.updateEventLastDateTimePicker.Size = new System.Drawing.Size(166, 23);
            this.updateEventLastDateTimePicker.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Last Update";
            // 
            // updateEventDescriptionTextBox
            // 
            this.updateEventDescriptionTextBox.Location = new System.Drawing.Point(168, 95);
            this.updateEventDescriptionTextBox.Multiline = true;
            this.updateEventDescriptionTextBox.Name = "updateEventDescriptionTextBox";
            this.updateEventDescriptionTextBox.Size = new System.Drawing.Size(166, 86);
            this.updateEventDescriptionTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Event Description";
            // 
            // updateEventButton
            // 
            this.updateEventButton.Location = new System.Drawing.Point(168, 201);
            this.updateEventButton.Name = "updateEventButton";
            this.updateEventButton.Size = new System.Drawing.Size(166, 30);
            this.updateEventButton.TabIndex = 3;
            this.updateEventButton.Text = "Update Event";
            this.updateEventButton.UseVisualStyleBackColor = true;
            this.updateEventButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // updateEventTitleTextBox
            // 
            this.updateEventTitleTextBox.Location = new System.Drawing.Point(168, 19);
            this.updateEventTitleTextBox.Name = "updateEventTitleTextBox";
            this.updateEventTitleTextBox.Size = new System.Drawing.Size(166, 23);
            this.updateEventTitleTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Title";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteEventButton);
            this.groupBox3.Controls.Add(this.deleteEventTitleTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 118);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Event";
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Location = new System.Drawing.Point(114, 69);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(166, 30);
            this.deleteEventButton.TabIndex = 3;
            this.deleteEventButton.Text = "Delete Event";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // deleteEventTitleTextBox
            // 
            this.deleteEventTitleTextBox.Location = new System.Drawing.Point(114, 22);
            this.deleteEventTitleTextBox.Name = "deleteEventTitleTextBox";
            this.deleteEventTitleTextBox.Size = new System.Drawing.Size(166, 23);
            this.deleteEventTitleTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Event Title";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SearchEventByImportanceComboBox);
            this.groupBox4.Controls.Add(this.SearchEventByImportanceDataGridView);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(451, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 203);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search by Event Importance";
            // 
            // SearchEventByImportanceComboBox
            // 
            this.SearchEventByImportanceComboBox.FormattingEnabled = true;
            this.SearchEventByImportanceComboBox.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less"});
            this.SearchEventByImportanceComboBox.Location = new System.Drawing.Point(171, 22);
            this.SearchEventByImportanceComboBox.Name = "SearchEventByImportanceComboBox";
            this.SearchEventByImportanceComboBox.Size = new System.Drawing.Size(121, 27);
            this.SearchEventByImportanceComboBox.TabIndex = 7;
            this.SearchEventByImportanceComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchEventByImportanceComboBox_SelectedIndexChanged);
            // 
            // SearchEventByImportanceDataGridView
            // 
            this.SearchEventByImportanceDataGridView.AllowUserToAddRows = false;
            this.SearchEventByImportanceDataGridView.AllowUserToDeleteRows = false;
            this.SearchEventByImportanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchEventByImportanceDataGridView.Location = new System.Drawing.Point(10, 61);
            this.SearchEventByImportanceDataGridView.Name = "SearchEventByImportanceDataGridView";
            this.SearchEventByImportanceDataGridView.ReadOnly = true;
            this.SearchEventByImportanceDataGridView.Size = new System.Drawing.Size(309, 136);
            this.SearchEventByImportanceDataGridView.TabIndex = 6;
            this.SearchEventByImportanceDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchEventByImportanceDataGridView_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Importance of Event";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadListOfEventsGridView
            // 
            this.loadListOfEventsGridView.AllowUserToAddRows = false;
            this.loadListOfEventsGridView.AllowUserToDeleteRows = false;
            this.loadListOfEventsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadListOfEventsGridView.Location = new System.Drawing.Point(451, 50);
            this.loadListOfEventsGridView.Name = "loadListOfEventsGridView";
            this.loadListOfEventsGridView.ReadOnly = true;
            this.loadListOfEventsGridView.Size = new System.Drawing.Size(336, 170);
            this.loadListOfEventsGridView.TabIndex = 8;
            this.loadListOfEventsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadListOfEventsGridView_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "List of Events";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 468);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loadListOfEventsGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update / Delete / Search Event ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManagement_FormClosing);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchEventByImportanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadListOfEventsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateEventButton;
        private System.Windows.Forms.TextBox updateEventTitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.TextBox deleteEventTitleTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView SearchEventByImportanceDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView loadListOfEventsGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker updateEventLastDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox updateEventDescriptionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SearchEventByImportanceComboBox;
    }
}