namespace WinFormsCarMarketplace
{
    public partial class MainForm : Form
    {
        public CarMarket CarMarket { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CarMarket = new CarMarket();
            RefreshCarList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddCar addCarForm = new FormAddCar();
            addCarForm.ShowDialog(this);
        }

        public void RefreshCarList()
        {
            listBoxCars.Items.Clear();
            listBoxCars.Items.AddRange(CarMarket.Cars.ToArray());
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Car car = listBoxCars.SelectedItem as Car;
            CarMarket.RemoveCar(car);
            RefreshCarList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CarMarket.Save();
        }
    }
}