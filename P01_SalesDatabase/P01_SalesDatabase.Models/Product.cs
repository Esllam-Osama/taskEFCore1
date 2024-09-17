using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.P01_SalesDatabase.Models
{
  internal class Product
  {
    public int ProductId { get; set; }
    public string Names { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public int Sales { get; set; }

  }
}
