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
        public static String partselected = String.Empty;
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
            //Formatting
            PartResults.Items.Add("");
            PartResults.Items.Clear();
            //Search for parts that match the term
            foreach (dynamic part in ApplicationData.AllParts)
            {
                if (part.Name.ToLower().Contains(PartSearch.Text.ToLower()) && PartSearch.Text != "")
                {
                    string id = System.Convert.ToString(part.partID);
                    string inv = System.Convert.ToString(part.inStock);
                    string price = System.Convert.ToString(part.Price);
                    string[] row = { id, part.Name, inv, price};
                    var listViewItem = new ListViewItem(row);
                    PartResults.Items.Add(listViewItem);
                }
            }
        }

        private void PartSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModPartButton_Click(object sender, EventArgs e)
        {
            Hide();
            ModPart mod = new ModPart();
            mod.ShowDialog();
            mod = null;
            Show();
        }

        private void PartResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            partselected = PartResults.SelectedItems[0].Text;
        }

        private void DelPartButton_Click(object sender, EventArgs e)
        {
            dynamic deletepart = string.Empty;
            //Confirm Delete
            var confirmResult = MessageBox.Show("Are you sure you want to delete the selected item?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {     
                foreach (dynamic part in ApplicationData.AllParts)
                {
                    if (System.Convert.ToString(part.partID) == partselected)
                    {
                        deletepart = part;
                        PartResults.Items.Clear();
                    }
                }
                ApplicationData.AllParts.Remove(deletepart);
            }
        }
    }
}
