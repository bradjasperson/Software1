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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OutsourcedRD_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                if (radioButton.Checked)
                {
                    MachineLabel.Text = "Company Name";
                    EnterMachID.Text = "Company Name";
                }
            }
        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void InHouseRD_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                if (radioButton.Checked)
                {
                    MachineLabel.Text = "Machine ID";
                    EnterMachID.Text = "Mach ID";
                }
            }

        }

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

        private void Save_Click(object sender, EventArgs e)
        {

            //Error Handling
            var errormsg = string.Empty;
            int result;
            int min;
            int max;
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
            //If there is an error, display error messages in Add Part window.
            if (errormsg != "")
            {
                ErrorLabel.Text = errormsg;
            }
            else
            {
                //TODO catch if it's outsourced, add all fields, add part to an array. Test gets.
                //Create InHouse part object
                if (MachineLabel.Text == "Machine ID")
                {
                    InHouse part = new InHouse();
                    Random rnd = new Random();
                    int rndprtid = rnd.Next(1, 99999);
                    part.partID = rndprtid;
                    part.Name = EnterPartName.Text;
                    part.Price = System.Convert.ToDouble(EnterPrice.Text);
                    part.inStock = System.Convert.ToInt32(EnterInv.Text);
                    part.Min = System.Convert.ToInt32(EnterMin.Text);
                    part.Max = System.Convert.ToInt32(EnterMax.Text);
                    part.MachineID = System.Convert.ToInt32(EnterMachID.Text);
                    ApplicationData.AllParts.Add(part);
                }
                else
                {
                    Outsourced part = new Outsourced();
                    Random rnd = new Random();
                    int rndprtid = rnd.Next(1, 99999);
                    part.partID = rndprtid;
                    part.Name = EnterPartName.Text;
                    part.Price = System.Convert.ToDouble(EnterPrice.Text);
                    part.inStock = System.Convert.ToInt32(EnterInv.Text);
                    part.Min = System.Convert.ToInt32(EnterMin.Text);
                    part.Max = System.Convert.ToInt32(EnterMax.Text);
                    part.companyName = EnterMachID.Text;
                    ApplicationData.AllParts.Add(part);
                }
                Close();
            }
        }
    }
}
