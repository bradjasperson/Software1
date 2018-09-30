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
    public partial class ModProduct : Form
    {
        public ModProduct(Product product)
        {
            InitializeComponent();
            //Populate text fields with values of selected part to modify.
            var productid = System.Convert.ToString(product.productID);
            var inv = System.Convert.ToString(product.inStock);
            var min = System.Convert.ToString(product.Min);
            var max = System.Convert.ToString(product.Max);
            var price = System.Convert.ToString(product.Price);
            EnterProductName.Text = product.Name;
            ROProductID.Text = productid;
            EnterInv.Text = inv;
            EnterPrice.Text = price;
            EnterMin.Text = min;
            EnterMax.Text = max;
            //Populate the parts that are part of the product to the listview
            foreach (dynamic part in product.AssociatedParts)
            {
                var partid = System.Convert.ToString(part.partID);
                var partinv = System.Convert.ToString(part.inStock);
                var partprice = System.Convert.ToString(part.Price);
                string[] row = { partid, part.Name, partinv, partprice };
                var listViewItem = new ListViewItem(row);
                PartList.Items.Add(listViewItem);
            }
        }
        //Initialize partselected variable
        public static String partselected = String.Empty;
        //Set the variable partselected if an item in the box is clicked
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
        //Search parts
        private void SearchPart_Click(object sender, EventArgs e)
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
                    string[] row = { id, part.Name, inv, price };
                    var listViewItem = new ListViewItem(row);
                    PartResults.Items.Add(listViewItem);
                }
            }
        }
        //Add part to productlist
        private void AddPartButton_Click(object sender, EventArgs e)
        {
            if (partselected != "")
            {
                dynamic addpart = string.Empty;
                foreach (dynamic part in ApplicationData.AllParts)
                {
                    if (System.Convert.ToString(part.partID) == partselected)
                    {
                        addpart = part;
                        string id = System.Convert.ToString(part.partID);
                        string inv = System.Convert.ToString(part.inStock);
                        string price = System.Convert.ToString(part.Price);
                        string[] row = { id, part.Name, inv, price };
                        var listViewItem = new ListViewItem(row);
                        PartList.Items.Add(listViewItem);
                    }
                }
            }
        }
        //Delete part from product list
        private void DeletePart_Click(object sender, EventArgs e)
        {
            if (PartList.SelectedItems[0].ToString() != "")
            {
                PartList.SelectedItems[0].Remove();
            }
        }
        //Cancel
        private void Cancel_Click(object sender, EventArgs e)
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
        //Save modified part to product list
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
            if (PartList != null)
            {
                foreach (ListViewItem listpart in PartList.Items)
                {
                    foreach (dynamic partfind in ApplicationData.AllParts)
                    {
                        if (listpart.Text == partfind.partID.ToString())
                        {
                            parts.Add(partfind);
                        }
                    }
                }
            }
            //Get the total cost of parts
            double partcosttotal = 0;
            foreach (dynamic part in parts)
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
                product.productID = System.Convert.ToInt32(ROProductID.Text);
                product.Name = EnterProductName.Text;
                product.Price = System.Convert.ToDouble(EnterPrice.Text);
                product.inStock = System.Convert.ToInt32(EnterInv.Text);
                product.Min = System.Convert.ToInt32(EnterMin.Text);
                product.Max = System.Convert.ToInt32(EnterMax.Text);
                product.AssociatedParts = parts;
                //Add the modified part to the list of parts
                int index = ApplicationData.AllProducts.FindIndex(a => a.productID == product.productID);
                ApplicationData.AllProducts[index] = product;
                Close();
            }
        }
    }
}