namespace InventoryManagement.Models
{
   public abstract class Part
   {
      public int ID { get; protected set; }           // set by InStock (auto-gen)
      public string Name { get; set; }                // non-empty
      public decimal Price { get; set; }              // >= 0
      public int InStock { get; private set; }        // must be between Min/Max
      public int Min { get; private set; }            // >= 0
      public int Max { get; private set; }            // >= Min


      protected Part(int id, string name, int inv, decimal price, int min, int max)
      {
         // assign fields
         // ValidateInvariants(); // throw DomainException (or collect errors)

         // if ValidateInvariants();

         ID = id;
         Name = name;
         InStock = inv;
         Price = price;
         Min = min;
         Max = max;

      }

      // Domain operations that keep the object valid
      public void SetRange(int min, int max)
      {
         // set min/max
         // ValidateInvariants();
         // if InStock now outside range, decide: clamp? reject? (prefer reject)

      }

      public void SetInventory(int value)
      {
         // require Min <= value <= Max; otherwise reject
      }

      public void SetPrice(decimal value)
      {
         // require value >= 0
      }

      // Centralized invariant check (called by ctor/setters)
      protected void ValidateInvariants()
      {
         // - Name not null/empty
         // - Min <= Max
         // - InStock in [Min, Max]
         // - Price >= 0
         // Throw a domain-specific exception or aggregate messages
      }
   }
}