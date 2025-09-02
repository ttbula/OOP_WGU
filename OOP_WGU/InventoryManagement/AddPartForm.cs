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
   public partial class AddPartForm : Form
   {
      public AddPartForm()
      {
         InitializeComponent();
      }

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
   }
}
