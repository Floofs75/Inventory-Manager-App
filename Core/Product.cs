namespace InventoryManager.Core
{
    public class Product
    {
        public int ID { get; set; } //primary key
        public string Name { get; set; } = string.Empty; //item name
        public string SKU { get; set; } = string.Empty; //Stock Keeping Unit number
        public int Quantity { get; set; } //quantity of stock
        public decimal Price { get; set; } //stock price per unit
    }
}
