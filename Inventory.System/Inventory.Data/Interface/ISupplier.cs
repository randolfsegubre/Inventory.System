using System;
using System.Collections.Generic;
using System.Text;
using static Inventory.Data.Enums;

namespace Inventory.Data.Interface
{
    public interface ISupplier
    {
        int Id { get; set; }
        string Name { get; set; }
        string Company { get; set; }
        string Industry { get; set; }
        DateTime DateRegister { get; set; }
        string Status { get; set; }
    }
}
