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
        //Initialize partselected variable
        public static String partselected = String.Empty;
        private void AddProductBox_Enter(object sender, EventArgs e)
        {

        }
        //Search for part
        private void SearchPart_Click(object sender, EventArgs e)
        {
            //Formatting
            PartResults.Items.Add("");
            PartResults.Items.Clear();
            //Search for parts that match the term
            Main newmain = new Main();
            dynamic searchResults = newmain.LookupPart(PartSearch.Text, false);
            if (searchResults.Count != 0 && PartSearch.Text != "")
            {
                foreach (dynamic part in searchResults)
                {
                    string id = System.Convert.ToString(part.partID);
                    string inv = System.Convert.ToString(part.inStock);
                    string price = System.Convert.ToString(part.Price);
                    string[] row = { id, part.Name, inv, price };
                    var listViewItem = new ListViewItem(row);
                    PartResults.Items.Add(listViewItem);
                }
            }
            else
            {
                searchResults.Clear();
                PartResults.Items.Clear();
            }
        }
        //Save partselected
        private void PartResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                partselected = PartResults.SelectedItems[0].Text;
            }
            catch
            {
                partselected = string.Empty;
            }
        }
        //Add selected part to partlist
        private void AddPartButton_Click(object sender, EventArgs e)
        {
            if (partselected != "")
            {
                Main newmain = new Main();
                dynamic addpart = newmain.LookupPart(partselected, true);
                string id = System.Convert.ToString(addpart.partID);
                string inv = System.Convert.ToString(addpart.inStock);
                string price = System.Convert.ToString(addpart.Price);
                string[] row = { id, addpart.Name, inv, price };
                var listViewItem = new ListViewItem(row);
                PartList.Items.Add(listViewItem);
                
            }
        }
        //Delete selected part from partlist
        private void DeletePart_Click(object sender, EventArgs e)
        {
            if (PartList.SelectedItems[0].ToString() != "")
            {
                PartList.SelectedItems[0].Remove();
            }
        }
        //Cancel
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
        //Save the product
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Error Handling
            var errormsg = string.Empty;
            int result;
            int min;
            int max;
            double productcost;
            //Get the list of parts to add to the product as a list of Parts type
            List<Part> parts = new List<Part>();
            if(PartList != null)
            {
                foreach(ListViewItem listpart in PartList.Items)
                {
                    Main newmain = new Main();
                    dynamic partfind = newmain.LookupPart(listpart.Text, true);
                    parts.Add(partfind);
                }
            }
            //Get the total cost of parts
            double partcosttotal = 0;
            foreach(dynamic part in parts)
            {
                partcosttotal += part.Price;
            }
            //Error Handling
            if (int.TryParse(EnterInv.Text, out result) == false)
            {
                errormsg += "Inventory must be a number!\n";
            }
            if (int.TryParse(EnterMax.Text, out max) == false || int.TryParse(EnterMin.Text, out min) == false)
            {
                errormsg += "Max and Min must be a number!\n";
            }
            else if (min > max || max < min)
            {
                errormsg += "Max must be greater than Min and Min must be greater than Max!";
            }
            if (double.TryParse(EnterPrice.Text, out productcost) == false)
            {
                errormsg += "Price/Cost must be a number!";
            }
            else if (productcost < partcosttotal)
            {
                errormsg += "Price/Cost can't be less than the total cost of parts!";
            }
            //If there is an error, display error messages in Add Product window.
            if (errormsg != "")
            {
                ErrorLabel.Text = errormsg;
            }
            else
            {
                Product product = new Product();
               
                //Populate the rest of the object properties
                Random rnd = new Random();
                int rndprtid = rnd.Next(1, 99999);
                product.productID = rndprtid;
                product.Name = EnterProductName.Text;
                product.Price = System.Convert.ToDouble(EnterPrice.Text);
                product.inStock = System.Convert.ToInt32(EnterInv.Text);
                product.Min = System.Convert.ToInt32(EnterMin.Text);
                product.Max = System.Convert.ToInt32(EnterMax.Text);
                product.AssociatedParts = parts;
                //Add the part to the list of parts
                Main.products.Add(product);
                Close();
            }
        }
    }
}
