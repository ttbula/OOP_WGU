using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagement.Models;
using System.Windows.Forms;

namespace InventoryManagement
{
   internal static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Inventory.SeedData();
         Application.Run(new MainForm());
      }
   }
}
