

namespace InventoryManager
{
    public class Product
    {
        public string ID { get; set; } //primary key
        public string Name { get; set; } //item name
        public string SKU { get; set; } //Stock Keeping Unit number
        public int Quantity { get; set; } //quantity of stock
        public decimal Price { get; set; } //stock price per unit
    }
}
