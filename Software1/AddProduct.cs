using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProductBox_Enter(object sender, EventArgs e)
        {

        }

        private void PartSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {

        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Confirm Cancel
            var confirmResult = MessageBox.Show("Are you sure you want to cancel?",
                                     "Confirm Cancel",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
