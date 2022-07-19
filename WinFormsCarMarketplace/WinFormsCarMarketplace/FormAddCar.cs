using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCarMarketplace
{
    public partial class FormAddCar : Form
    {
        public FormAddCar()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Owner is MainForm mainForm)
            {
                mainForm.CarMarket.Cars.Add(new Car(textBoxBrand.Text, (int)numericUpDownYear.Value, 
                                                    textBoxSPZ.Text, (int)numericUpDownValue.Value));
                mainForm.RefreshCarList();
            }
            Close();
        }
    }
}
