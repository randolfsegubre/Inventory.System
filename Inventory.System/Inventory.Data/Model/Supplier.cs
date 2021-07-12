using Inventory.Data.Interface;
using System;

namespace Inventory.Data.Model
{
    public class Supplier : ISupplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public DateTime DateRegister { get; set; }
        public string Status { get; set; }
        public string Industry { get ; set ; }
    }
}
