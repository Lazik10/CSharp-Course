namespace ClientDatabaseCSV
{
    partial class Form1
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUserDatabase = new System.Windows.Forms.Label();
            this.labelUserDatabaseInfo = new System.Windows.Forms.Label();
            this.groupBoxUserDetails = new System.Windows.Forms.GroupBox();
            this.labelUserDetailRegistrationShow = new System.Windows.Forms.Label();
            this.labelUserDetailRegistration = new System.Windows.Forms.Label();
            this.labelUserDetailAgeShow = new System.Windows.Forms.Label();
            this.labelUserDetailAge = new System.Windows.Forms.Label();
            this.labelUserDetailNameShow = new System.Windows.Forms.Label();
            this.labelUserDetailName = new System.Windows.Forms.Label();
            this.groupBoxAddUser = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownAddUserGetAge = new System.Windows.Forms.NumericUpDown();
            this.labelAddUserAge = new System.Windows.Forms.Label();
            this.textBoxAddUserGetName = new System.Windows.Forms.TextBox();
            this.labelAddUserName = new System.Windows.Forms.Label();
            this.dateTimePickerAddUserRegistration = new System.Windows.Forms.DateTimePicker();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxUserDetails.SuspendLayout();
            this.groupBoxAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddUserGetAge)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(443, 402);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(78, 30);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Ulozit";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonUloz_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(549, 402);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(78, 30);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Nacist";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 15;
            this.listUsers.Location = new System.Drawing.Point(12, 98);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(271, 334);
            this.listUsers.Sorted = true;
            this.listUsers.TabIndex = 2;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 65);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelUserDatabase
            // 
            this.labelUserDatabase.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserDatabase.Location = new System.Drawing.Point(114, 12);
            this.labelUserDatabase.Name = "labelUserDatabase";
            this.labelUserDatabase.Size = new System.Drawing.Size(239, 36);
            this.labelUserDatabase.TabIndex = 4;
            this.labelUserDatabase.Text = "Databaze Uzivatelu";
            // 
            // labelUserDatabaseInfo
            // 
            this.labelUserDatabaseInfo.AutoSize = true;
            this.labelUserDatabaseInfo.Location = new System.Drawing.Point(123, 62);
            this.labelUserDatabaseInfo.Name = "labelUserDatabaseInfo";
            this.labelUserDatabaseInfo.Size = new System.Drawing.Size(138, 15);
            this.labelUserDatabaseInfo.TabIndex = 5;
            this.labelUserDatabaseInfo.Text = "Ukazkova aplikace Lazika";
            // 
            // groupBoxUserDetails
            // 
            this.groupBoxUserDetails.Controls.Add(this.buttonRemove);
            this.groupBoxUserDetails.Controls.Add(this.labelUserDetailRegistrationShow);
            this.groupBoxUserDetails.Controls.Add(this.labelUserDetailRegistration);
            this.groupBoxUserDetails.Controls.Add(this.labelUserDetailAgeShow);
            this.groupBoxUserDetails.Controls.Add(this.labelUserDetailAge);
            this.groupBoxUserDetails.Controls.Add(this.labelUserDetailNameShow);
            this.groupBoxUserDetails.Controls.Add(this.labelUserDetailName);
            this.groupBoxUserDetails.Location = new System.Drawing.Point(310, 98);
            this.groupBoxUserDetails.Name = "groupBoxUserDetails";
            this.groupBoxUserDetails.Size = new System.Drawing.Size(211, 298);
            this.groupBoxUserDetails.TabIndex = 6;
            this.groupBoxUserDetails.TabStop = false;
            this.groupBoxUserDetails.Text = "Detail uzivatele";
            // 
            // labelUserDetailRegistrationShow
            // 
            this.labelUserDetailRegistrationShow.AutoSize = true;
            this.labelUserDetailRegistrationShow.Location = new System.Drawing.Point(6, 176);
            this.labelUserDetailRegistrationShow.Name = "labelUserDetailRegistrationShow";
            this.labelUserDetailRegistrationShow.Size = new System.Drawing.Size(0, 15);
            this.labelUserDetailRegistrationShow.TabIndex = 5;
            // 
            // labelUserDetailRegistration
            // 
            this.labelUserDetailRegistration.AutoSize = true;
            this.labelUserDetailRegistration.Location = new System.Drawing.Point(0, 149);
            this.labelUserDetailRegistration.Name = "labelUserDetailRegistration";
            this.labelUserDetailRegistration.Size = new System.Drawing.Size(73, 15);
            this.labelUserDetailRegistration.TabIndex = 4;
            this.labelUserDetailRegistration.Text = "Registration:";
            // 
            // labelUserDetailAgeShow
            // 
            this.labelUserDetailAgeShow.AutoSize = true;
            this.labelUserDetailAgeShow.Location = new System.Drawing.Point(6, 112);
            this.labelUserDetailAgeShow.Name = "labelUserDetailAgeShow";
            this.labelUserDetailAgeShow.Size = new System.Drawing.Size(0, 15);
            this.labelUserDetailAgeShow.TabIndex = 3;
            // 
            // labelUserDetailAge
            // 
            this.labelUserDetailAge.AutoSize = true;
            this.labelUserDetailAge.Location = new System.Drawing.Point(0, 87);
            this.labelUserDetailAge.Name = "labelUserDetailAge";
            this.labelUserDetailAge.Size = new System.Drawing.Size(31, 15);
            this.labelUserDetailAge.TabIndex = 2;
            this.labelUserDetailAge.Text = "Age:";
            // 
            // labelUserDetailNameShow
            // 
            this.labelUserDetailNameShow.AutoSize = true;
            this.labelUserDetailNameShow.Location = new System.Drawing.Point(0, 49);
            this.labelUserDetailNameShow.Name = "labelUserDetailNameShow";
            this.labelUserDetailNameShow.Size = new System.Drawing.Size(0, 15);
            this.labelUserDetailNameShow.TabIndex = 1;
            // 
            // labelUserDetailName
            // 
            this.labelUserDetailName.AutoSize = true;
            this.labelUserDetailName.Location = new System.Drawing.Point(-2, 25);
            this.labelUserDetailName.Name = "labelUserDetailName";
            this.labelUserDetailName.Size = new System.Drawing.Size(42, 15);
            this.labelUserDetailName.TabIndex = 0;
            this.labelUserDetailName.Text = "Name:";
            // 
            // groupBoxAddUser
            // 
            this.groupBoxAddUser.Controls.Add(this.buttonAdd);
            this.groupBoxAddUser.Controls.Add(this.numericUpDownAddUserGetAge);
            this.groupBoxAddUser.Controls.Add(this.labelAddUserAge);
            this.groupBoxAddUser.Controls.Add(this.textBoxAddUserGetName);
            this.groupBoxAddUser.Controls.Add(this.labelAddUserName);
            this.groupBoxAddUser.Controls.Add(this.dateTimePickerAddUserRegistration);
            this.groupBoxAddUser.Location = new System.Drawing.Point(549, 98);
            this.groupBoxAddUser.Name = "groupBoxAddUser";
            this.groupBoxAddUser.Size = new System.Drawing.Size(215, 298);
            this.groupBoxAddUser.TabIndex = 7;
            this.groupBoxAddUser.TabStop = false;
            this.groupBoxAddUser.Text = "Pridat Uzivatele";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(72, 235);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 30);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Pridat";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownAddUserGetAge
            // 
            this.numericUpDownAddUserGetAge.Location = new System.Drawing.Point(89, 112);
            this.numericUpDownAddUserGetAge.Name = "numericUpDownAddUserGetAge";
            this.numericUpDownAddUserGetAge.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownAddUserGetAge.TabIndex = 4;
            // 
            // labelAddUserAge
            // 
            this.labelAddUserAge.AutoSize = true;
            this.labelAddUserAge.Location = new System.Drawing.Point(6, 114);
            this.labelAddUserAge.Name = "labelAddUserAge";
            this.labelAddUserAge.Size = new System.Drawing.Size(28, 15);
            this.labelAddUserAge.TabIndex = 3;
            this.labelAddUserAge.Text = "Age";
            // 
            // textBoxAddUserGetName
            // 
            this.textBoxAddUserGetName.Location = new System.Drawing.Point(9, 67);
            this.textBoxAddUserGetName.Name = "textBoxAddUserGetName";
            this.textBoxAddUserGetName.Size = new System.Drawing.Size(200, 23);
            this.textBoxAddUserGetName.TabIndex = 2;
            // 
            // labelAddUserName
            // 
            this.labelAddUserName.AutoSize = true;
            this.labelAddUserName.Location = new System.Drawing.Point(9, 49);
            this.labelAddUserName.Name = "labelAddUserName";
            this.labelAddUserName.Size = new System.Drawing.Size(61, 15);
            this.labelAddUserName.TabIndex = 1;
            this.labelAddUserName.Text = "Full Name";
            // 
            // dateTimePickerAddUserRegistration
            // 
            this.dateTimePickerAddUserRegistration.Location = new System.Drawing.Point(9, 158);
            this.dateTimePickerAddUserRegistration.Name = "dateTimePickerAddUserRegistration";
            this.dateTimePickerAddUserRegistration.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerAddUserRegistration.TabIndex = 0;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(64, 235);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(78, 30);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Odebrat";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAddUser);
            this.Controls.Add(this.groupBoxUserDetails);
            this.Controls.Add(this.labelUserDatabaseInfo);
            this.Controls.Add(this.labelUserDatabase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Name = "Form1";
            this.Text = "User Database";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxUserDetails.ResumeLayout(false);
            this.groupBoxUserDetails.PerformLayout();
            this.groupBoxAddUser.ResumeLayout(false);
            this.groupBoxAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddUserGetAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSave;
        private Button buttonLoad;
        private ListBox listUsers;
        private PictureBox pictureBox1;
        private Label labelUserDatabase;
        private Label labelUserDatabaseInfo;
        private GroupBox groupBoxUserDetails;
        private GroupBox groupBoxAddUser;
        private Label labelAddUserAge;
        private TextBox textBoxAddUserGetName;
        private Label labelAddUserName;
        private DateTimePicker dateTimePickerAddUserRegistration;
        private Label labelUserDetailNameShow;
        private Label labelUserDetailName;
        private Button buttonAdd;
        private NumericUpDown numericUpDownAddUserGetAge;
        private Label labelUserDetailRegistrationShow;
        private Label labelUserDetailRegistration;
        private Label labelUserDetailAgeShow;
        private Label labelUserDetailAge;
        private Button buttonRemove;
    }
}