namespace ClientDatabaseCSV
{
    public partial class Form1 : Form
    {
        private Database _database;

        public Form1()
        {
            InitializeComponent();
            // Use %APPDATA% instead in real time world
            _database = new Database("users.csv");
        }

        private void buttonUloz_Click(object sender, EventArgs e)
        {
            try
            {
                _database.Save();
            }
            catch
            {
                MessageBox.Show("Database was not saved, please check your file permission.", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                _database.Load();
                listUsers.Items.Clear();
                listUsers.Items.AddRange(_database.AllUsers());
            }
            catch
            {
                MessageBox.Show("Database could not be loaded, file probably doesn't exist",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _database.AddUser(textBoxAddUserGetName.Text.Replace(";", " "),
                              (int)numericUpDownAddUserGetAge.Value,
                              dateTimePickerAddUserRegistration.Value);
            listUsers.Items.Clear();
            listUsers.Items.AddRange(_database.AllUsers());
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem != null)
            {
                User user = (User)listUsers.SelectedItem;
                labelUserDetailNameShow.Text = user.Name;
                labelUserDetailAgeShow.Text = user.Age.ToString();
                labelUserDetailRegistrationShow.Text = user.Registration.ToShortDateString();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            User user = (User)listUsers.SelectedItem;
            _database.Remove(user);
            listUsers.Items.Clear ();
            listUsers.Items.AddRange(_database.AllUsers());

            labelUserDetailNameShow.Text = "";
            labelUserDetailAgeShow.Text = "";
            labelUserDetailRegistrationShow.Text = "";
        }
    }
}