using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
   public partial class ModifyPartForm : Form
   {
      public ModifyPartForm(Part original)
      {
         InitializeComponent();
         this.AcceptButton = btnSave;
         rbInHouse.Checked = true;
         UIUpdatePartType();

         txtboxID.Text = original.ID.ToString();
         txtboxName.Text = original.Name;
         txtboxInventory.Text = original.InStock.ToString();
         txtboxPrice.Text = original.Price.ToString();
         txtboxMax.Text = original.Max.ToString();
         txtboxMin.Text = original.Min.ToString();

         if (original is Inhouse inhousePart)
         {
            txtboxMachineID.Text = inhousePart.MachineID.ToString();
         }
         else if (original is Outsourced outsourcedPart)
         {
            txtboxCompanyName.Text = outsourcedPart.CompanyName;
         }
      }

      public Part ModifiedPart { get; private set; }

      public bool IsInHouse => rbInHouse.Checked;

      private class ModifiedPartInput
      {
         public int ID { get; set; }
         public string Name { get; set; }
         public int Inventory { get; set; }
         public decimal Price { get; set; }
         public int Min { get; set; }
         public int Max { get; set; }

         public int MachineID { get; set; }
         public string CompanyName { get; set; }
      }

      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      //                                 Class Methods                                                          //
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////

      /// <summary>
      /// Called when UI must be updated. Grabs the current state of IsInHouse
      /// On Inhouse (default), MachineID label and textbox is displayed and enabled. Company Name label and textbox is disabled and hidden
      /// On Outsourced, Company Name label and textbox is displayed and enabled. Machine ID label and textbox is disabled and hidden
      /// </summary>
      private void UIUpdatePartType()
      {
         bool inHouse = rbInHouse.Checked;
         txtboxMachineID.Visible = lblMachineID.Visible = inHouse;
         txtboxMachineID.Enabled = inHouse;

         txtboxCompanyName.Visible = lblCompanyName.Visible = !inHouse;
         txtboxCompanyName.Enabled = lblCompanyName.Enabled = !inHouse;
      }

      /// <summary>
      /// Handles Inhouse/Outsourced button changes by updating the UI
      /// </summary>
      private void rbPartType_CheckedChanged(object sender, EventArgs e) => UIUpdatePartType();

      /// <summary>
      /// Sets the NewPart with either a Inhouse or Outsource instance
      /// Gets the correct radio button state, then adds all values to the PartInput class
      /// <param name="input">A built instance of PartInput</param>/>
      /// </summary>
      private void SetPartInput(ModifiedPartInput input)
      {
         try
         {
            if (IsInHouse)
            {
               ModifiedPart = new Inhouse(input.ID, input.Name, input.Inventory, input.Price, input.Min, input.Max, input.MachineID);
            }
            else
            {
               ModifiedPart = new Outsourced(input.ID, input.Name, input.Inventory, input.Price, input.Min, input.Max, input.CompanyName);
            }
         }

         catch (Exception)
         {
            MessageBox.Show("An unexpected error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }


      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      //                                 Validation Methods                                                     //
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      ///
      /// <summary>
      /// Validates every textbox in add part form
      /// Sets PartInput properties if all textboxes are determined to be valid
      /// <param name="input">Returns a built instance of PartInput</param>
      /// <param string="errorMessage">If a box is invalid, a custom message is returned. Else, an empty string</param>
      /// </summary>
      private bool IsFormValid(out ModifiedPartInput input, out string errorMessage)
      {
         input = new ModifiedPartInput();

         // Validate the textboxes, sets error message if invalid, sets textbox color to light coral (red), and returns false

         if (!ValidateAndGetInt(txtboxID, out int idValue)) { errorMessage = "ID Invalid"; SetTextboxColor(false, txtboxID); return false; }

         if (string.IsNullOrWhiteSpace(txtboxName.Text)) { errorMessage = "Name Invalid"; SetTextboxColor(false, txtboxName); return false; }

         if (!ValidateAndGetMinMax(txtboxMin, txtboxMax, out int minValue, out int maxValue)) { errorMessage = "Min/Max Invalid"; SetTextboxColor(false, txtboxMin); SetTextboxColor(false, txtboxMax); return false; }

         if (!ValidateAndGetInventory(txtboxInventory, minValue, maxValue, out int invValue)) { errorMessage = "Inventory not within min/max"; SetTextboxColor(false, txtboxInventory); return false; }

         if (!ValidateAndGetPrice(txtboxPrice, out decimal priceValue)) { errorMessage = "Price Invalid"; SetTextboxColor(false, txtboxPrice); return false; }

         // Set properties
         input.ID = idValue;
         input.Name = txtboxName.Text;
         input.Inventory = invValue;
         input.Price = priceValue;
         input.Min = minValue;
         input.Max = maxValue;

         // Get rb state. Validate/set appropriate properties
         if (IsInHouse)
         {
            if (ValidateAndGetMachineID(txtboxMachineID, out int machineIDValue))
            {
               input.MachineID = machineIDValue;
            }
            else
            {
               errorMessage = "Machine ID Invalid";
               SetTextboxColor(false, txtboxMachineID);
               return false;
            }
         }
         else if (!string.IsNullOrWhiteSpace(txtboxCompanyName.Text))
         {
            input.CompanyName = txtboxCompanyName.Text;
         }
         else
         {
            SetTextboxColor(false, txtboxCompanyName);
            errorMessage = "Company Name Invalid";
            return false;
         }

         // If no errors, return an empty string
         errorMessage = "";
         return true;
      }

      /// <summary>
      /// Validating Min/Max ranges. If conditions are met, we return the min & max values along with a true boolean
      /// If false, we return the 0'd out values along with a false boolean
      /// <param Textbox="minBox">The minimum textbox property name</param>
      /// <param Textbox="maxBox">The maximum textbox property name</param>
      /// <param int="minValue">If true, a valid min value is returned. If false, a 0</param>
      /// <param int="maxValue">If true, a valid max value is returned. If false, a 0</param>
      /// </summary>
      private bool ValidateAndGetMinMax(System.Windows.Forms.TextBox minBox, System.Windows.Forms.TextBox maxBox, out int minValue, out int maxValue)
      {
         minValue = 0;
         maxValue = 0;
         // Ensure the input is a valid int
         if (ValidateAndGetInt(minBox, out int convertedMin) && ValidateAndGetInt(maxBox, out int convertedMax))
         {
            // Minimum must be less than or equal to the max
            if (convertedMin >= convertedMax)
            {
               return false;
            }
            // Set the out parameters
            minValue = convertedMin;
            maxValue = convertedMax;
            return true;
         }
         return false;
      }

      /// <summary>
      /// Validating Inventory value. If conditions are met, we return the inventory along with a true boolean
      /// If false, we return the 0'd out values along with a false boolean
      /// <param Textbox="box">The inventory textbox property name</param>
      /// <param int="minValue">The current minimum value</param>
      /// <param int="maxValue">The current maximum value</param>
      /// <param int="inv">If true, a valid inventory value is returned. If false, a 0</param>
      /// </summary>
      private bool ValidateAndGetInventory(System.Windows.Forms.TextBox box, int min, int max, out int inv)
      {
         inv = 0;
         // Ensure it is a valid int
         if (ValidateAndGetInt(box, out int validatedInv))
         {
            // Inventory must be within min & max
            if (min <= validatedInv && validatedInv <= max)
            {
               inv = validatedInv;
               return true;
            }
         }
         return false;
      }

      /// <summary>
      /// Validating Machine ID value. If conditions are met, we return the machine id along with a true boolean
      /// If false, we return the 0'd out values along with a false boolean
      /// <param Textbox="box">The machine ID textbox property name</param>
      /// <param int="machID">If true, a valid machID value is returned. If false, a 0</param>
      /// </summary>
      private bool ValidateAndGetMachineID(System.Windows.Forms.TextBox box, out int machID)
      {
         machID = 0;
         if (ValidateAndGetInt(box, out int validMachID))
         {
            if (validMachID > 0)
            {
               machID = validMachID;
               return true;
            }
         }
         return false;
      }

      /// <summary>
      /// Validating Price. Price is required to be a decimal. Grabs textbox value and tries to parse decimal
      /// <returns>True if valid</returns>
      /// <returns>False if invalid</returns>
      /// <returns>The converted int</returns>
      /// <param name="boxName">The name associated with the textbox being validated</param>
      /// <param name="convertedNum">Returns the validated int</param>
      /// </summary>
      private bool ValidateAndGetPrice(System.Windows.Forms.TextBox boxName, out decimal convertedDecimal)
      {
         // TryParse method returns true if valid number
         bool isValid = decimal.TryParse(boxName.Text, out convertedDecimal);
         if (!isValid || convertedDecimal <= 0)
         {
            return false;
         }
         return true;
      }

      /// <summary>
      /// Determines if a textbox value is an integer. Grabs textbox value and tries to parse int
      /// <returns>True if valid</returns>
      /// <returns>False if invalid</returns>
      /// <returns>The converted int</returns>
      /// <param name="boxName">The name associated with the textbox being validated</param>
      /// <param name="convertedNum">Returns the validated int</param>
      /// </summary>
      private bool ValidateAndGetInt(System.Windows.Forms.TextBox boxName, out int convertedNum)
      {
         // TryParse method returns true if valid number
         bool isValid = int.TryParse(boxName.Text, out convertedNum);
         if (!isValid)
         {
            SetTextboxColor(false, boxName);
            return false;
         }
         return true;
      }

      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      //                                 Controller Events                                                      //
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////

      /// <summary>
      /// If first argument is true set textbox color to white, false set to light coral (reddish color, just not as jarring as default red)
      /// <param bool="value">Boolean indicating what color to change box to</param>
      /// <param name="boxName">The name associated with the textbox color assignment</param>
      /// </summary>
      private void SetTextboxColor(bool value, System.Windows.Forms.TextBox boxName)
      {
         if (value)
         {
            boxName.BackColor = Color.White;
         }
         else
         {
            boxName.BackColor = Color.LightCoral;
         }
      }

      /// <summary>
      /// On Save Button click
      /// Verifies forms validity, then if valid, builds NewPart 
      /// NewPart is then added to InStock before closing the Add Part form
      /// If form is not valid it presents user with error message before returning. Add Part form is not closed
      /// </summary>
      /// <param name="sender"></param>   
      /// <param name="e"></param>
      private void btnSave_Click(object sender, EventArgs e)
      {
         // Ensure the form is valid before sending data off
         if (!IsFormValid(out ModifiedPartInput input, out string errorMessage))
         {
            MessageBox.Show($"{errorMessage}. Please review the form before resubmitting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         this.SetPartInput(input);

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
      /// Captures text changes in Name textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxName_TextChanged(object sender, EventArgs e)
      {
         if (!string.IsNullOrWhiteSpace(txtboxName.Text))
         {
            SetTextboxColor(true, txtboxName);
         }
         else
         {
            SetTextboxColor(false, txtboxName);
         }
      }

      /// <summary>
      /// Captures text changes in ID textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxID_TextChanged(object sender, EventArgs e)
      {
         if (ValidateAndGetInt(txtboxID, out int id))
         {
            SetTextboxColor(true, txtboxID);
         }
         else
         {
            SetTextboxColor(false, txtboxID);
         }
      }

      /// <summary>
      /// Captures text changes in InStock textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxInventory_TextChanged(object sender, EventArgs e)
      {
         if (ValidateAndGetInt(txtboxInventory, out int inv))
         {
            SetTextboxColor(true, txtboxInventory);
         }
         else
         {
            SetTextboxColor(false, txtboxInventory);
         }
      }

      /// <summary>
      /// Captures text changes in Price textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxPrice_TextChanged(object sender, EventArgs e)
      {
         if (ValidateAndGetPrice(txtboxPrice, out decimal price))
         {
            SetTextboxColor(true, txtboxPrice);
         }
         else
         {
            SetTextboxColor(false, txtboxPrice);
         }
      }

      /// <summary>
      /// Captures text changes in Max textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxMax_TextChanged(object sender, EventArgs e)
      {
         if (ValidateAndGetInt(txtboxMax, out int max))
         {
            SetTextboxColor(true, txtboxMax);
         }
         else
         {
            SetTextboxColor(false, txtboxMax);
         }
      }

      /// <summary>
      /// Captures text changes in Min textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxMin_TextChanged(object sender, EventArgs e)
      {
         if (ValidateAndGetInt(txtboxMin, out int min))
         {
            SetTextboxColor(true, txtboxMin);
         }
         else
         {
            SetTextboxColor(false, txtboxMin);
         }
      }

      /// <summary>
      /// Captures text changes in Company Name textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxCompanyName_TextChanged(object sender, EventArgs e)
      {
         if (!string.IsNullOrWhiteSpace(txtboxCompanyName.Text))
         {
            SetTextboxColor(true, txtboxCompanyName);
         }
         else
         {
            SetTextboxColor(false, txtboxCompanyName);
         }
      }

      /// <summary>
      /// Captures text changes in Machine ID textbox and sends it to be validated
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void txtboxMachineID_TextChanged(object sender, EventArgs e)
      {
         if (ValidateAndGetInt(txtboxMachineID, out int mach))
         {
            SetTextboxColor(true, txtboxMachineID);
         }
         else
         {
            SetTextboxColor(false, txtboxMachineID);
         }
      }
   }
}
