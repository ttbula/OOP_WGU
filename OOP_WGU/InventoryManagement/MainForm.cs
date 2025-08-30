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
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      private void btnAddParts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Add Parts");
      }

      private void btnModifyParts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Modify Parts");
      }

      private void btnDeleteParts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Delete Parts");
      }

      private void btnSearchParts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Search Parts");
      }

      private void btnAddProducts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Add Products");
      }

      private void btnModifyProducts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Modify Products");
      }

      private void btnDeleteProducts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Delete Products");
      }

      private void btnSearchProducts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Search Products");
      }

      private void btnExit_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Exit");
      }

   }
}
