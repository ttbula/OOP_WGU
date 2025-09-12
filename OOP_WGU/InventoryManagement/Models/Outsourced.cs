namespace InventoryManagement.Models
{
   public class Outsourced : Part
   {
      public string CompanyName { get; set; }

      public Outsourced(int id, string name, int inv, decimal price, int min, int max, string companyName)
          : base(id, name, inv, price, min, max)
      {
         CompanyName = companyName;
      }
   }
}