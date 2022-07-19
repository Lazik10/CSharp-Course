namespace SerializationDeserialization
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(205, 12);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(187, 23);
            this.textBoxSurname.TabIndex = 1;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(639, 12);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(149, 23);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Add";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(398, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(235, 23);
            this.dateTimePicker.TabIndex = 3;
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 15;
            this.listBoxUsers.Location = new System.Drawing.Point(12, 45);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(776, 169);
            this.listBoxUsers.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 220);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Name = "MainForm";
            this.Text = "Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Button buttonAddUser;
        private DateTimePicker dateTimePicker;
        private ListBox listBoxUsers;
    }
}