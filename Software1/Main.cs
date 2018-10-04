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
        //Initialize variables
        public static String partselected = String.Empty;
        public static String productselected = String.Empty;

        //Product and part lists. This is where all products and parts are stored while the program runs.
        public static List<Part> allParts = new List<Part>();
        public static List<Product> products = new List<Product>();

        //Part
        public void addPart()
        {
            //This is handled by clicking the AddPartButton, it calls AddPart.cs
        }
        //Go to the form that adds a part
        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddPart add = new AddPart();
            add.ShowDialog();
            add = null;
            Show();

        }
        //Search for part by name or id
        public dynamic LookupPart(dynamic search, bool exact)
        {
            if (exact)
            {
                foreach(dynamic part in allParts)
                {
                    if (part.partID.ToString() == search)
                    {
                        return part;
                    }
                }
            }
           List<dynamic> results = new List<dynamic>();
            results.Clear();
           foreach(dynamic part in allParts)
            {
                if (part.Name.ToLower().Contains(search.ToLower()))
                {
                    results.Add(part);
                }
            }
            return results;
        }
        private void PartSearchButton_Click(object sender, EventArgs e)
        {
            //Formatting
            PartResults.Items.Add("");
            PartResults.Items.Clear();

            //Search for parts that match the term
            dynamic searchResults = LookupPart(PartSearch.Text, false);
            if (searchResults.Count!=0 && PartSearch.Text !="")
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

        private void PartSearch_TextChanged(object sender, EventArgs e)
        {

        }
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
        private void updatePart()
        {
            //This is handled when the ModPartButton is clicked it calls ModPart.cs
        }
        //Modify/Update selected part
        private void ModPartButton_Click(object sender, EventArgs e)
        {
            if (partselected != "")
            {
                dynamic modpart = LookupPart(partselected, true);
                Hide();
                ModPart mod = new ModPart(modpart);
                mod.ShowDialog();
                mod = null;
                Show();
                PartResults.Items.Clear();
            }
        }

        //Delete Part
        private void deletePart()
        {
            //This task is handled when the DelPartButton is clicked, it is only called from there 
            //so there is no need to break it out into a separate function
        }
        private void DelPartButton_Click(object sender, EventArgs e)
        {
            var errormsg = string.Empty;
            //Confirm Delete
            var confirmResult = MessageBox.Show("Are you sure you want to delete the selected item?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                dynamic deletepart = LookupPart(partselected, true); 

                //Check to make sure that the part is not associated with any product, stop and throw an error if there is.
                foreach (Product product in products)
                {
                    bool isassociated = product.LookUpAssociatedParts(deletepart);
                    if (isassociated)
                    {
                        errormsg = "The selected part cannot be deleted because it is associated with at least one product!";
                    }
                }

                if (errormsg != "")
                {
                    ErrorLabel.Text = errormsg;
                }
                else
                {
                    //Remove a part from the parts list.
                    PartResults.Items.Clear();
                    allParts.Remove(deletepart);
                }
            }
        }
        //Product
        //Add Product
        public void addProduct()
        {
            //This is handled by clicking the ProductAddButton, it calls AddProduct.cs
        }
        private void ProductAddButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddProduct add = new AddProduct();
            add.ShowDialog();
            add = null;
            Show();
        }
        //Search for product by name or id
        public dynamic LookupProduct(dynamic search, bool exact)
        {
            if (exact)
            {
                foreach (dynamic product in products)
                {
                    if (product.productID.ToString() == search)
                    {
                        return product;
                    }
                }
            }
            List<dynamic> results = new List<dynamic>();
            results.Clear();
            foreach (dynamic product in products)
            {
                if (product.Name.ToLower().Contains(search.ToLower()))
                {
                    results.Add(product);
                }
            }
            return results;
        }
        private void ProductSearchButton_Click(object sender, EventArgs e)
        {
            //Formatting
            ProductResults.Items.Add("");
            ProductResults.Items.Clear();

            //Search for parts that match the term
            dynamic searchResults = LookupProduct(ProductSearch.Text, false);
            if (searchResults.Count != 0 && ProductSearch.Text != "")
            {
                foreach (dynamic product in searchResults)
                {
                    string id = System.Convert.ToString(product.productID);
                    string inv = System.Convert.ToString(product.inStock);
                    string price = System.Convert.ToString(product.Price);
                    string[] row = { id, product.Name, inv, price };
                    var listViewItem = new ListViewItem(row);
                    ProductResults.Items.Add(listViewItem);
                }
            }
            else
            {
                searchResults.Clear();
                ProductResults.Items.Clear();
            }
        }
        private void ProductResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                productselected = ProductResults.SelectedItems[0].Text;
            }
            catch
            {
                productselected = string.Empty;
            }
        }
        //Modify Product
        public void updateProduct()
        {
            //This is handled by clicking the ProductModifyButton it calls ModProduct.cs
        }
        private void ProductModifyButton_Click(object sender, EventArgs e)
        {
            if (productselected != "")
            {
                Product modproduct = LookupProduct(productselected, true);
                ProductResults.Items.Clear();
                Hide();
                ModProduct mod = new ModProduct(modproduct);
                mod.ShowDialog();
                mod = null;
                Show();
            }
        }
        public void removeProduct()
        {
            //This is handled by clicking the ProductDeleteButton
        }
        //Delete Product
        private void ProductDeleteButton_Click(object sender, EventArgs e)
        {
            //Confirm Delete
            var confirmResult = MessageBox.Show("Are you sure you want to delete the selected item?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Product deleteproduct = LookupProduct(productselected, true);
                ProductResults.Items.Clear();
                products.Remove(deleteproduct);
            }
        }
        //Quit program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Confirm Exit
            var confirmResult = MessageBox.Show("Are you sure you want to exit?",
                                     "Confirm Exit",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
