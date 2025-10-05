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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
         Inventory.SeedData();
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
      /// Takes user to Add Product Form Page
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnAddProducts_Click(object sender, EventArgs e)
      {
         AddProductForm addProduct = new AddProductForm();
         if (addProduct.ShowDialog() == DialogResult.OK)
         {
            Inventory.AddProduct(addProduct.NewProduct);
         }
      }

      /// <summary>
      /// Takes user to Modify Part Form Page
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
      /// Takes user to Modify Products Page
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnModifyProducts_Click(object sender, EventArgs e)
      {
         if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.DataBoundItem is Product selectedProduct)
         {
            ModifyProductForm modifyProduct = new ModifyProductForm(selectedProduct);
            if (modifyProduct.ShowDialog() == DialogResult.OK)
            {  
               var updated = modifyProduct.ModifiedProduct;
               Inventory.UpdateProduct(updated.ProductID, updated);
            }
         }
      }

      /// <summary>
      /// Deletes the currently selected part
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

         if (MessageBox.Show("Delete selected part?", "Confirm",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
         {
            return;
         }

         bool removed = Inventory.RemovePart(part.ID);
         if (!removed)
         {
            MessageBox.Show("Cannot delete a part that is associated with a product.",
                            "Delete Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
      }

      /// <summary>
      /// Deletes the currently selected product
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnDeleteProducts_Click(object sender, EventArgs e)
      {
         var prod = dgvProducts.CurrentRow?.DataBoundItem as Product;
         if (prod == null) 
         {
            MessageBox.Show("Select a product."); 
            return; 
         }
         if (MessageBox.Show("Delete selected product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
         {
            return;
         }

         Inventory.RemoveProduct(prod.ProductID);
      }

      /// <summary>
      /// Searches all parts for an ID or name
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnSearchParts_Click(object sender, EventArgs e)
      {
         string q = txtboxSearchParts.Text.Trim();
         Part hit = int.TryParse(q, out var id) ? Inventory.LookupPart(id)
                                                : Inventory.FindPartsByName(q).FirstOrDefault();
         SelectRow(dgvParts, hit, "No matching part found.");
      }

      /// <summary>
      /// Searches all products for an ID or name
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnSearchProducts_Click(object sender, EventArgs e)
      {
         string q = txtboxSearchProducts.Text.Trim();
         Product hit = int.TryParse(q, out var id) ? Inventory.LookupProduct(id)
                                                   : Inventory.FindProductsByName(q).FirstOrDefault();
         SelectRow(dgvProducts, hit, "No matching product found.");
      }

      /// <summary>
      /// Exits the UI
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      /// <summary>
      /// Highlights a specific item in a DataGridView if it exists in the bound list.
      /// </summary>
      /// <param name="dgv">The DataGridView to search within.</param>
      /// <param name="item">The item to locate and select.</param>
      /// <param name="msg">Message to display if the item is not found.</param>
      private void SelectRow(DataGridView dgv, object item, string msg)
      {
         if (item == null) { MessageBox.Show(msg); return; }
         var list = (System.Collections.IList)dgv.DataSource;
         int i = list.IndexOf(item);
         if (i < 0) { MessageBox.Show(msg); return; }
         dgv.ClearSelection();
         dgv.Rows[i].Selected = true;
         dgv.CurrentCell = dgv.Rows[i].Cells[0];
         dgv.FirstDisplayedScrollingRowIndex = i;
      }
   }
}
