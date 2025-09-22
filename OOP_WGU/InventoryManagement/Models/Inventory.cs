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
      public static BindingList<Product> Products { get; } = new BindingList<Product>();

      public static void addProduct(Product product)
      {
         Products.Add(product);
      }

      public static bool removeProduct(int id)
      {
         var productToRemove = Products.FirstOrDefault(p => p.ProductID == id);
         if (productToRemove != null)
         {
            Products.Remove(productToRemove);
            return true;
         }
         return false;
      }

      public static void addPart(Part part)
      {
         AllParts.Add(part);
      }

      public static void updatePart(int id, Part updated)
      {
         int index = AllParts.ToList().FindIndex(p => p.ID == id);

         if (index >= 0)
         {
            AllParts[index] = updated;
         }
      }

      public static bool removePart(int id)
      {
         var partToRemove = AllParts.FirstOrDefault(p => p.ID == id);
         if (partToRemove != null)
         {
            AllParts.Remove(partToRemove);
            return true;
         }
         return false;
      }
      
   }
}
