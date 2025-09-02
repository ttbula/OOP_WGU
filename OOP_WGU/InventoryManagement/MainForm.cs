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
         //List<Part> parts = new List<Part>
         //{
         //   new Part { ID = 1, Name = "Part A", Inventory = 10, Price = 5.99m, Min = 1, Max = 20 },
         //   new Part { ID = 2, Name = "Part B", Inventory = 15, Price = 9.99m, Min = 5, Max = 30 },
         //   new Part { ID = 3, Name = "Part C", Inventory = 8, Price = 12.49m, Min = 2, Max = 25 }
         //};

         //List<Product> products = new List<Product>
         //{
         //   new Product { ID = 1, Name = "Product A", Inventory = 10, Price = 5.99m, Min = 1, Max = 20 },
         //   new Product { ID = 2, Name = "Product B", Inventory = 15, Price = 9.99m, Min = 5, Max = 30 },
         //   new Product { ID = 3, Name = "Product C", Inventory = 8, Price = 12.49m, Min = 2, Max = 25 }
         //};

         //dgvParts.DataSource = parts;
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
         this.Close();
      }
   }
}
