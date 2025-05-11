namespace InventoryApi.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; } // Nullable
        public int Quantity { get; set; }
        public string? Location { get; set; } // Nullable
    }
}