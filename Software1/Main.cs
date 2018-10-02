﻿using System;
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
        //Product and part lists. 
        public static List<Part> allParts = new List<Part>();
        public static List<Product> products = new List<Product>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Parts_Enter(object sender, EventArgs e)
        {

        }
        //Part
        //Go to addpart
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
        //Modify/Update selected part
        private void ModPartButton_Click(object sender, EventArgs e)
        {
            if (partselected != "")
            {
                dynamic modpart = string.Empty;
                foreach (dynamic part in ApplicationData.AllParts)
                {
                    if (System.Convert.ToString(part.partID) == partselected)
                    {
                        modpart = part;
                        PartResults.Items.Clear();
                    }
                }
                Hide();
                ModPart mod = new ModPart(modpart);
                mod.ShowDialog();
                mod = null;
                Show();
            }
        }
        //Delete Part
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
   
                /*foreach (Product product in ApplicationData.AllProducts)
                {
                    if (product.AssociatedParts.Contains(deletepart))
                    {
                        errormsg = "The selected part cannot be deleted because it is associated with at least one product!";
                    }
                }*/
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
        //Search For Product
        private void ProductSearchButton_Click(object sender, EventArgs e)
        {
            //Formatting
            ProductResults.Items.Add("");
            ProductResults.Items.Clear();
            //Search for parts that match the term
            foreach (Product product in ApplicationData.AllProducts)
            {
                if (product.Name.ToLower().Contains(ProductSearch.Text.ToLower()) && ProductSearch.Text != "")
                {
                    string id = System.Convert.ToString(product.productID);
                    string inv = System.Convert.ToString(product.inStock);
                    string price = System.Convert.ToString(product.Price);
                    string[] row = { id, product.Name, inv, price };
                    var listViewItem = new ListViewItem(row);
                    ProductResults.Items.Add(listViewItem);
                }
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
        private void ProductAddButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddProduct add = new AddProduct();
            add.ShowDialog();
            add = null;
            Show();
        }

        private void ProductDeleteButton_Click(object sender, EventArgs e)
        {
            dynamic deleteproduct = string.Empty;
            //Confirm Delete
            var confirmResult = MessageBox.Show("Are you sure you want to delete the selected item?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                foreach (dynamic product in ApplicationData.AllProducts)
                {
                    if (System.Convert.ToString(product.productID) == productselected)
                    {
                        deleteproduct = product;
                        ProductResults.Items.Clear();
                    }
                }
                ApplicationData.AllProducts.Remove(deleteproduct);
            }
        }

        private void ProductModifyButton_Click(object sender, EventArgs e)
        {
            if (productselected != "")
            {
                dynamic modproduct = string.Empty;
                foreach (Product product in ApplicationData.AllProducts)
                {
                    if (System.Convert.ToString(product.productID) == productselected)
                    {
                        modproduct = product;
                        ProductResults.Items.Clear();
                    }
                }
                Hide();
                ModProduct mod = new ModProduct(modproduct);
                mod.ShowDialog();
                mod = null;
                Show();
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
