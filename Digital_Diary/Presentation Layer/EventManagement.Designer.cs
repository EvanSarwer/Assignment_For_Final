namespace Digital_Diary.Presentation_Layer
{
    partial class EventManagement
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
            this.loadEentListGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addEventTitleTextBox = new System.Windows.Forms.TextBox();
            this.addEventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addEventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addEventImportanceComboBox = new System.Windows.Forms.ComboBox();
            this.addEventUserComboBox = new System.Windows.Forms.ComboBox();
            this.addEventButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadEentListGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadEentListGridView
            // 
            this.loadEentListGridView.AllowUserToAddRows = false;
            this.loadEentListGridView.AllowUserToDeleteRows = false;
            this.loadEentListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadEentListGridView.Location = new System.Drawing.Point(422, 52);
            this.loadEentListGridView.Name = "loadEentListGridView";
            this.loadEentListGridView.ReadOnly = true;
            this.loadEentListGridView.Size = new System.Drawing.Size(366, 171);
            this.loadEentListGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Events";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addEventButton);
            this.groupBox1.Controls.Add(this.addEventUserComboBox);
            this.groupBox1.Controls.Add(this.addEventImportanceComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addEventDateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addEventDescriptionTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addEventTitleTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 305);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Event Title";
            // 
            // addEventTitleTextBox
            // 
            this.addEventTitleTextBox.Location = new System.Drawing.Point(117, 40);
            this.addEventTitleTextBox.Name = "addEventTitleTextBox";
            this.addEventTitleTextBox.Size = new System.Drawing.Size(193, 20);
            this.addEventTitleTextBox.TabIndex = 1;
            // 
            // addEventDescriptionTextBox
            // 
            this.addEventDescriptionTextBox.Location = new System.Drawing.Point(117, 116);
            this.addEventDescriptionTextBox.Multiline = true;
            this.addEventDescriptionTextBox.Name = "addEventDescriptionTextBox";
            this.addEventDescriptionTextBox.Size = new System.Drawing.Size(193, 64);
            this.addEventDescriptionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Event Description";
            // 
            // addEventDateTimePicker
            // 
            this.addEventDateTimePicker.Location = new System.Drawing.Point(117, 80);
            this.addEventDateTimePicker.Name = "addEventDateTimePicker";
            this.addEventDateTimePicker.Size = new System.Drawing.Size(193, 20);
            this.addEventDateTimePicker.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Importance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "User";
            // 
            // addEventImportanceComboBox
            // 
            this.addEventImportanceComboBox.FormattingEnabled = true;
            this.addEventImportanceComboBox.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less"});
            this.addEventImportanceComboBox.Location = new System.Drawing.Point(117, 198);
            this.addEventImportanceComboBox.Name = "addEventImportanceComboBox";
            this.addEventImportanceComboBox.Size = new System.Drawing.Size(193, 21);
            this.addEventImportanceComboBox.TabIndex = 9;
            // 
            // addEventUserComboBox
            // 
            this.addEventUserComboBox.FormattingEnabled = true;
            this.addEventUserComboBox.Location = new System.Drawing.Point(117, 233);
            this.addEventUserComboBox.Name = "addEventUserComboBox";
            this.addEventUserComboBox.Size = new System.Drawing.Size(193, 21);
            this.addEventUserComboBox.TabIndex = 10;
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(117, 271);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(193, 23);
            this.addEventButton.TabIndex = 11;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // EventManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadEentListGridView);
            this.Name = "EventManagement";
            this.Text = "EventManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventManagement_FormClosing);
            this.Load += new System.EventHandler(this.EventManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadEentListGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loadEentListGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.ComboBox addEventUserComboBox;
        private System.Windows.Forms.ComboBox addEventImportanceComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker addEventDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEventDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEventTitleTextBox;
        private System.Windows.Forms.Label label2;
    }
}