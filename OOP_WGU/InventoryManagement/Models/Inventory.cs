using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
   public class Inventory
   {
      public static BindingList<Part> AllParts { get; } = new BindingList<Part>();
   }
}
