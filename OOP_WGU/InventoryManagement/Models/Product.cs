﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
   internal class Product
   {
      public int ID { get; set; }
      public string Name { get; set; }
      public int Inventory { get; set; }
      public decimal Price { get; set; }
      public int Min { get; set; }
      public int Max { get; set; }
   }
}
