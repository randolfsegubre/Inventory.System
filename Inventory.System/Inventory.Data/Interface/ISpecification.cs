﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Interface
{
    public interface ISpecification
    {
        string Model { get; set; }
        string Brand { get; set; }
    }
}
