using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Models;

namespace InventoryManagement
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      private void LoadData()
      {
         dgvParts.DataSource = Inventory.AllParts ;
         dgvProducts.DataSource = Inventory.Products;
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         LoadData();
      }

      /// <summary>
      /// Takes user to Add Part Form Page
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnAddParts_Click(object sender, EventArgs e)
      {
         //addParts.NewPart
         AddPartForm addParts = new AddPartForm();
         if (addParts.ShowDialog() == DialogResult.OK)
         {
            Inventory.AddPart(addParts.NewPart);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnModifyParts_Click(object sender, EventArgs e)
      {
         if (dgvParts.CurrentRow != null && dgvParts.CurrentRow.DataBoundItem is Part selectedPart)
         {
            ModifyPartForm modifyParts = new ModifyPartForm(selectedPart);
            if (modifyParts.ShowDialog() == DialogResult.OK)
            {
               var updated = modifyParts.ModifiedPart;
               Inventory.UpdatePart(updated.ID, updated);
            }
         }
         else
         {
            MessageBox.Show("Please select a part to modify.");
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnDeleteParts_Click(object sender, EventArgs e)
      {
         var part = dgvParts.CurrentRow?.DataBoundItem as Part;
         if (part == null)
         {
            MessageBox.Show("Please select a part to delete.");
            return;
         }

         var result = MessageBox.Show("Are you sure you want to delete the part?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
         if (result == DialogResult.Yes)
         {
            // eventually this will need to have out string reason
            if (!Inventory.RemovePart(part.ID))
            {
               MessageBox.Show("");
            }
         }
         
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnSearchParts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Search Parts");
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnAddProducts_Click(object sender, EventArgs e)
      {
         AddProductForm addProduct = new AddProductForm();
         if (addProduct.ShowDialog() == DialogResult.OK)
         {
            //Inventory.UpdateProduct();
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnModifyProducts_Click(object sender, EventArgs e)
      {
         if (dgvParts.CurrentRow != null && dgvParts.CurrentRow.DataBoundItem is Part selectedPart)
         {
            ModifyProductForm modifyProduct = new ModifyProductForm();
            if (modifyProduct.ShowDialog() == DialogResult.OK)
            {
               //var updated = modifyProduct.ModifiedPart;
               //Inventory.UpdateProduct(updated.ID, updated);
            }
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnDeleteProducts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Delete Products");
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnSearchProducts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Search Products");
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
