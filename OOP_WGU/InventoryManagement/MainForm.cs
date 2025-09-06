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
         //dgvProducts.DataSource = products;
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
         AddPartForm addParts = new AddPartForm();
         addParts.ShowDialog();
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnModifyParts_Click(object sender, EventArgs e)
      {
         
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnDeleteParts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Delete Parts");
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
         MessageBox.Show("Add Products");
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnModifyProducts_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Modify Products");
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
