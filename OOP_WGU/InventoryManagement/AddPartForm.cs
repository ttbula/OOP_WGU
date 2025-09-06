using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagement
{
   public partial class AddPartForm : Form
   {
      public AddPartForm()
      {
         InitializeComponent();
      }

      public Part NewPart { get; private set; }


      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      //                                 Class Methods                                                          //
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////

      /// <summary>
      /// Gets the correct radio button state, then adds all values to the corresponding class
      /// </summary>
      private void BuildNewPart()
      {
         try
         {
            if (rbInHouse.Checked)
            {
               NewPart = new Inhouse
               {
                  ID = int.Parse(txtboxID.Text),
                  Name = txtboxName.Text,
                  Inventory = int.Parse(txtboxInventory.Text),
                  Price = decimal.Parse(txtboxPrice.Text),
                  Min = int.Parse(txtboxMin.Text),
                  Max = int.Parse(txtboxMax.Text),
                  MachineID = int.Parse(txtboxMachineID.Text)
               };
            }
            else
            {
               NewPart = new Outsourced
               {
                  ID = int.Parse(txtboxID.Text),
                  Name = txtboxName.Text,
                  Inventory = int.Parse(txtboxInventory.Text),
                  Price = decimal.Parse(txtboxPrice.Text),
                  Min = int.Parse(txtboxMin.Text),
                  Max = int.Parse(txtboxMax.Text),
                  // to access: ((Outsourced)NewPart).CompanyName
                  CompanyName = txtboxCompanyName.Text
               };
            }
         }
         catch (Exception)
         {
            MessageBox.Show("An unexpected error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      /// <summary>
      /// Determines if string has a valid input (not empty). If so box will change to white. If invalid, box will be red
      /// <returns>True if valid</returns>
      /// <returns>False if invalid</returns>
      /// /// <param name="boxName">The name associated with the textbox being validated</param>
      /// </summary>
      private bool IsStringValid(System.Windows.Forms.TextBox boxName)
      {
         if (string.IsNullOrEmpty(boxName.Text))
         {
            boxName.BackColor = Color.LightCoral;
            return false;
         }
         else
         {
            boxName.BackColor = Color.White;
         }
         return true;
      }

      /// <summary>
      /// Determines if number has a valid input (numbers only). If so box will change to white. If invalid, box will be red
      /// <returns>True if valid</returns>
      /// <returns>False if invalid</returns>
      /// <param name="boxName">The name associated with the textbox being validated</param>
      /// </summary>
      private bool IsNumValid(System.Windows.Forms.TextBox boxName)
      {
         // TryParse method returns true if valid number
         bool isValid = int.TryParse(boxName.Text, out int id);
         if (!isValid)
         {
            boxName.BackColor = Color.LightCoral;
            return false;
         }
         else
         {
            boxName.BackColor = Color.White;
         }
         return true;
      }

      /// <summary>
      /// Determines if all textboxes have valid values
      /// <returns>True if valid</returns>
      /// <returns>False if invalid</returns>
      /// </summary>
      private bool IsFormValid()
      {
         if (
            IsStringValid(txtboxName)
            && IsNumValid(txtboxID)
            && IsNumValid(txtboxInventory)
            && IsNumValid(txtboxPrice)
            && IsNumValid(txtboxMin)
            && IsNumValid(txtboxMax)
            )
         {
            // Get radio button state to determine which box to validate
            if(rbInHouse.Checked)
            {
               if(IsNumValid(txtboxMachineID))
               {
                  return true;
               }
            }
            else
            {
               if (IsStringValid(txtboxCompanyName))
               {
                  return true;
               }
            }
         }
         return false;
      }

      

      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      //                                 Controller Events                                                      //
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////

      /// <summary>
      /// On Save Button click
      /// Verifies forms validity, then if valid, builds NewPart 
      /// NewPart is then added to Inventory before closing the Add Part form
      /// If form is not valid it presents user with error message before returning. Add Part form is not closed
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnSave_Click(object sender, EventArgs e)
      {
         if (!IsFormValid())
         {
            MessageBox.Show("Please review the form before resubmitting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         this.BuildNewPart();
         Inventory.AllParts.Add(NewPart);
         this.DialogResult = DialogResult.OK;
         this.Close();
      }

      /// <summary>
      /// On Cancel Button click
      /// Closes the Add Part form. Part is not built, verification is not required
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      /// <summary>
      /// On Outsourced radio-button click
      /// Enables and displays Company Name, disables and hides Machine ID
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void rbOutsourced_Click(object sender, EventArgs e)
      {
         // Display Company Name Textbox
         this.txtboxCompanyName.Enabled = true;
         this.lblCompanyName.Visible = true;
         this.txtboxCompanyName.Visible = true;

         // Disable and hide Machine ID Textbox
         this.txtboxMachineID.Enabled = false;
         this.lblMachineID.Visible = false;
         this.txtboxMachineID.Visible = false;
      }

      /// <summary>
      /// On In House Click radio-button click
      /// Enables and displays Machine ID, disables and hides Company Name
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void rbInHouse_Click(object sender, EventArgs e)
      {
         // Display Machine ID Textbox
         this.txtboxMachineID.Enabled = true;
         this.lblMachineID.Visible = true;
         this.txtboxMachineID.Visible = true;

         // Disable and hide Company Name Textbox
         this.txtboxCompanyName.Enabled = false;
         this.lblCompanyName.Visible = false;
         this.txtboxCompanyName.Visible = false;
      }

      /// <summary>
      /// Captures text changes in Name textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxName_TextChanged(object sender, EventArgs e)
      {
         IsStringValid(txtboxName);
      }

      /// <summary>
      /// Captures text changes in ID textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxID_TextChanged(object sender, EventArgs e)
      {
         IsNumValid(txtboxID);
      }

      /// <summary>
      /// Captures text changes in Inventory textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxInventory_TextChanged(object sender, EventArgs e)
      {
         IsNumValid(txtboxInventory);
      }

      /// <summary>
      /// Captures text changes in Price textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxPrice_TextChanged(object sender, EventArgs e)
      {
         IsNumValid(txtboxPrice);
      }

      /// <summary>
      /// Captures text changes in Max textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxMax_TextChanged(object sender, EventArgs e)
      {
         IsNumValid(txtboxMax);
      }

      /// <summary>
      /// Captures text changes in Min textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxMin_TextChanged(object sender, EventArgs e)
      {
         IsNumValid(txtboxMin);
      }

      /// <summary>
      /// Captures text changes in Company Name textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxCompanyName_TextChanged(object sender, EventArgs e)
      {
         IsStringValid(txtboxCompanyName);
      }

      /// <summary>
      /// Captures text changes in Machine ID textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxMachineID_TextChanged(object sender, EventArgs e)
      {
         IsNumValid(txtboxMachineID);
      }
   }
}
