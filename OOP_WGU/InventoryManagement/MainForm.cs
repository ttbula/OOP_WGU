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

         if (MessageBox.Show("Delete selected part?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
         {
            return;
         }
         Inventory.RemovePart(part.ID);
      }

      /// <summary>
      /// 
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
      /// 
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
      /// 
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
      /// 
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
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

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
