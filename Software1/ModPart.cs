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
    public partial class ModPart : Form
    {
        public ModPart(dynamic part)
        {
            InitializeComponent();
            //Populate text fields with values of selected part to modify.
            var partid = System.Convert.ToString(part.partID);
            var inv = System.Convert.ToString(part.inStock);
            var min = System.Convert.ToString(part.Min);
            var max = System.Convert.ToString(part.Max);
            var price = System.Convert.ToString(part.Price);
            if (part.GetType().ToString().Contains("InHouse"))
            {
                var machid = System.Convert.ToString(part.MachineID);
                EnterMachID.Text = machid;
            }
            else
            {
                EnterMachID.Text = part.companyName;
            }
            EnterPartName.Text = part.Name;
            ROPartID.Text = partid;
            EnterInv.Text = inv;
            EnterPrice.Text = price;
            EnterMin.Text = min;
            EnterMax.Text = max;

            //Remove Part, It will be recreated as a new part but with the same ID
        }
       
        private void ModPartGrp_Enter(object sender, EventArgs e)
        {

        }

        private void ModPartBox_Enter(object sender, EventArgs e)
        {

        }

        private void InHouseRD_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                if (radioButton.Checked)
                {
                    MachineLabel.Text = "Machine ID";
                }
            }
        }

        private void OutsourcedRD_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                if (radioButton.Checked)
                {
                    MachineLabel.Text = "Company Name";
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

        private void ModSave_Click(object sender, EventArgs e)
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
                dynamic modpart = string.Empty;
                foreach (dynamic part in ApplicationData.AllParts)
                {
                    if (System.Convert.ToString(part.partID) == ROPartID.Text)
                    {
                        modpart = part;
                    }
                }
                //Modify InHouse part object
                bool readd = false;
                if (MachineLabel.Text == "Machine ID")
                {
                    if (modpart.GetType().ToString().Contains("Outsourced"))
                    {
                        ApplicationData.AllParts.Remove(modpart);
                        modpart = new InHouse();
                        readd = true;
                    }
                    modpart.MachineID = System.Convert.ToInt32(EnterMachID.Text);
                }
                //Modify Outsourced part object
                else
                {
                    if(modpart.GetType().ToString().Contains("InHouse"))
                    {
                        ApplicationData.AllParts.Remove(modpart);
                        modpart = new Outsourced();
                        readd = true;
                    }
                    modpart.companyName = EnterMachID.Text;
                }
                //Write the rest of the fields.
                modpart.partID = System.Convert.ToInt32(ROPartID.Text);
                modpart.Name = EnterPartName.Text;
                modpart.Price = System.Convert.ToDouble(EnterPrice.Text);
                modpart.inStock = System.Convert.ToInt32(EnterInv.Text);
                modpart.Min = System.Convert.ToInt32(EnterMin.Text);
                modpart.Max = System.Convert.ToInt32(EnterMax.Text);
                //Readd to list if it was removed
                if (readd)
                {
                    ApplicationData.AllParts.Add(modpart);
                }
                
                Close();
            }
        }
    }
}
