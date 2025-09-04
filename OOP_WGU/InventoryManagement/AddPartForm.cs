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

namespace InventoryManagement
{
   public partial class AddPartForm : Form
   {
      public AddPartForm()
      {
         InitializeComponent();
      }

      public Part NewPart { get; private set; }

      /// <summary>
      /// Enables and displays Company Name, disables and hides 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void rbOutsourced_Click(object sender, EventArgs e)
      {
         // Display Company Name Textbox
         this.txtboxCompanyName.Enabled = true;
         this.lblCompanyName.Visible = true;
         this.txtboxCompanyName.Visible = true;

         //disable
         this.txtboxMachineID.Enabled = false;
         this.lblMachineID.Visible = false;
         this.txtboxMachineID.Visible = false;
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param> 
      private void rbInHouse_Click(object sender, EventArgs e)
      {
         this.txtboxMachineID.Enabled = true;
         this.lblMachineID.Visible = true;
         this.txtboxMachineID.Visible = true;
         //disable
         this.txtboxCompanyName.Enabled = false;
         this.lblCompanyName.Visible = false;
         this.txtboxCompanyName.Visible = false;
      }

      /// <summary>
      /// Checks if value in textbox is an integer, if so it returns
      /// the integer. If not, it returns a 0
      /// </summary>
      /// <returns>int ID</returns>
      private int GetID()
      {
         bool isValid = int.TryParse(txtboxID.Text, out int id);
         if (isValid)
         {
            return id;
         }
         return 0;
      }

      /// <summary>
      /// Gets the value in Name textbox
      /// </summary>
      /// <returns>string Name</returns>
      private string GetName()
      {
         return txtboxName.Text;
      }

      /// <summary>
      /// Checks if value in textbox is an integer, if so it returns
      /// the integer. If not, it returns a 0
      /// </summary>
      /// <returns>int ID</returns>
      private int GetInventory()
      {
         bool isValid = int.TryParse(txtboxInventory.Text, out int inventory);
         if (isValid)
         {
            return inventory;
         }
         return 0;
      }

      private void BuildNewPart()
      {
         try
         {
            if (rbInHouse.Checked)
            {
               NewPart = new Inhouse
               {
                  ID = this.GetID(),
                  Name = this.GetName(),
                  Inventory = this.GetInventory(),
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
                  ID = this.GetID(),
                  Name = this.GetName(),
                  Inventory = this.GetInventory(),
                  Price = decimal.Parse(txtboxPrice.Text),
                  Min = int.Parse(txtboxMin.Text),
                  Max = int.Parse(txtboxMax.Text),
                  CompanyName = txtboxCompanyName.Text
               };
            }
         }
         catch (Exception)
         {
            MessageBox.Show("Please double check form");
         }
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         this.BuildNewPart();
         this.DialogResult = DialogResult.OK;
         this.Close();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      public Dictionary<string> GetParts;



   }
}
