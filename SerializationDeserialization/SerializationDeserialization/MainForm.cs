using System.Xml.Serialization;

namespace SerializationDeserialization
{
    public partial class MainForm : Form
    {
        List<User> users = new List<User>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                DateOfBirth = dateTimePicker.Value
            };

            users.Add(user);

            listBoxUsers.DataSource = null;
            listBoxUsers.DataSource = users;
        }

        private void Serialize()
        {
            try 
            {
                XmlSerializer serializer = new XmlSerializer(users.GetType());
                // Alternative
                //XmlSerializer serializer = new XmlSerializer(typeof(List<User>));

                using (StreamWriter sw = new StreamWriter("users.xml"))
                {
                    // First argument is stream and second is object which we serialize
                    serializer.Serialize(sw, users);
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.ToString());
            }
        }

        private void Deserialize()
        {
            try
            {
                if(File.Exists("users.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(users.GetType());
                    using (StreamReader sr = new StreamReader("users.xml"))
                    {
                        users = (List<User>)xmlSerializer.Deserialize(sr);
                    }
                }
                else throw new FileNotFoundException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialize();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Deserialize();
            listBoxUsers.DataSource = users;
        }
    }
}