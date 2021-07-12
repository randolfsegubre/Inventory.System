using Inventory.Data.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Data.Model
{
    public class Stock : IStock
    {   
        [Key]
        public int Id { get; set; }
        public string StockName { get; set; }
        public string StockType { get; set; }
        public string StockDescription { get; set; }
    }
}