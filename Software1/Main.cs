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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Parts_Enter(object sender, EventArgs e)
        {

        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddPart add = new AddPart();
            add.ShowDialog();
            add = null;
            Show();
        }
        private void PartSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void PartSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
