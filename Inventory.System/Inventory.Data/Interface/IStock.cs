namespace Inventory.Data.Interface
{
    public interface IStock
    {
        int Id { get; set; }
        string StockName { get; set; }
        string StockType { get; set; }
        string StockDescription { get; set; }
    }
}
