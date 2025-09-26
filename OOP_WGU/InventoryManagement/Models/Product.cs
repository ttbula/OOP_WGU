using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
   public class Product
   {
      public int ProductID { get; set; }
      public string Name { get; set; }
      public decimal Price { get; set; }
      public int InStock { get; set; }
      public int Min { get; set; }
      public int Max { get; set; }

      public BindingList<Part> AssociatedParts { get; } = new BindingList<Part>();

      public void AddAssociatedPart(Part part)
      {
         if (part != null && !AssociatedParts.Contains(part))
         {
            AssociatedParts.Add(part);
         }
      }

      public bool RemoveAssociatedPart(int id)
      {
         var partToRemove = AssociatedParts.FirstOrDefault(p => p.ID == id);
         if (partToRemove != null)
         {
            AssociatedParts.Remove(partToRemove);
            return true;
         }
         return false;
      }

   }

}
