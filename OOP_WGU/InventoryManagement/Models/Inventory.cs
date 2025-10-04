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

      public static Part LookupPart(int id)
      {
         return AllParts.FirstOrDefault(p => p.ID == id);
      }

      public static Product LookupProduct(int id)
      {
         return Products.FirstOrDefault(p => p.ProductID == id);
      }

      public static IEnumerable<Part> FindPartsByName(string name) =>
         AllParts.Where(p => p.Name?.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0);

      public static IEnumerable<Product> FindProductsByName(string name) =>
         Products.Where(pr => pr.Name?.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0);

      public static bool IsPartAssociated(int partId) =>
         Products.Any(prod => prod.AssociatedParts.Any(p => p.ID == partId));

      public static bool RemovePart(int id)
      {
         if (IsPartAssociated(id))
         {
            return false;
         }
         var partToRemove = AllParts.FirstOrDefault(p => p.ID == id);

         if (partToRemove == null)
         {
            return false;
         }
         AllParts.Remove(partToRemove);
         return true;
      }

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

      public static void SeedData()
      {
         // Seed Parts
         AllParts.Add(new Inhouse(GetNextPartID(), "Wheel", 15, 12m, 0, 18, 2268));
         AllParts.Add(new Inhouse(GetNextPartID(), "Frame", 5, 55m, 0, 10, 4455));
         AllParts.Add(new Outsourced(GetNextPartID(), "Bolt", 100, 0.25m, 0, 1000, "Acme Corp"));
         AllParts.Add(new Outsourced(GetNextPartID(), "Pedal", 25, 7.5m, 0, 50, "BikeParts Inc."));

         // Seed Products
         var bike = new Product
         {
            ProductID = GetNextProductID(),
            Name = "Mountain Bike",
            InStock = 3,
            Price = 199.99m,
            Min = 0,
            Max = 10
         };

         var scooter = new Product
         {
            ProductID = GetNextProductID(),
            Name = "Scooter",
            InStock = 7,
            Price = 89.99m,
            Min = 0,
            Max = 20
         };

         // Associate parts with products
         bike.AddAssociatedPart(AllParts[0]);    // Wheel
         bike.AddAssociatedPart(AllParts[1]);    // Frame
         scooter.AddAssociatedPart(AllParts[2]); // Bolt

         Products.Add(bike);
         Products.Add(scooter);
      }
      
   }
}
