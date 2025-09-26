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

      public static void AddProduct(Product product)
      {
         Products.Add(product);
      }

      private static int _nextPartID = 1;
      private static int _nextProductID = 1;

      public static int GetNextPartID()
      {
         int returnedID = _nextPartID;
         _nextPartID++;
         return returnedID;
      }

      public static int GetNextProductID()
      {
         int returnedID = _nextProductID;
         _nextProductID++;
         return returnedID;
      }

      public static bool RemoveProduct(int id)
      {
         var productToRemove = Products.FirstOrDefault(p => p.ProductID == id);
         if (productToRemove != null)
         {
            Products.Remove(productToRemove);
            return true;
         }
         return false;
      }

      public static void AddPart(Part part)
      {
         AllParts.Add(part);
      }

      public static void UpdatePart(int id, Part updated)
      {
         int index = AllParts.ToList().FindIndex(p => p.ID == id);

         if (index >= 0)
         {
            AllParts[index] = updated;
         }
      }

      public static void UpdateProduct(int id, Product updated)
      {
         int index = Products.ToList().FindIndex(p => p.ProductID == id);

         if (index >= 0)
         {
            Products[index] = updated;
         }
      }

      // eventually want this to have out string reason
      public static bool RemovePart(int id)
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
