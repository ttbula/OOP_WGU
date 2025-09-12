namespace InventoryManagement.Models
{
   public class Inhouse : Part
   {
      public int MachineID { get; set; }

      public Inhouse(int id, string name, int inv, decimal price, int min, int max, int machineId)
          : base(id, name, inv, price, min, max) 
      {
         MachineID = machineId;
      }
   }
}