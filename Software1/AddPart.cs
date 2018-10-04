using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This creates a part and adds it to the allParts list found in Main.cs
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
        //Radio button change to outsourced
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
        //Radio button change to inhouse
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
        //Save part
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
                errormsg += "Max must be greater than Min and Min must be greater than or equal to Max!";
            }
            //If there is an error, display error messages in Add Part window.
            if (errormsg != "")
            {
                ErrorLabel.Text = errormsg;
            }
            else
            {
                dynamic part;
                //Create InHouse part object
                if (MachineLabel.Text == "Machine ID")
                {
                    part = new InHouse();
                    part.MachineID = System.Convert.ToInt32(EnterMachID.Text);
                }
                else
                //Create Outsourced part object
                {
                    part = new Outsourced();
                    part.companyName = EnterMachID.Text; 
                }
                //Populate the rest of the object properties
                Random rnd = new Random();
                int rndprtid = rnd.Next(1, 99999);
                part.partID = rndprtid;
                part.Name = EnterPartName.Text;
                part.Price = System.Convert.ToDouble(EnterPrice.Text);
                part.inStock = System.Convert.ToInt32(EnterInv.Text);
                part.Min = System.Convert.ToInt32(EnterMin.Text);
                part.Max = System.Convert.ToInt32(EnterMax.Text);
                //Add the part to the list of parts.
                Main.allParts.Add(part);
                Close();
            }
        }
    }
}
