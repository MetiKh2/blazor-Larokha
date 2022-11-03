namespace Larokha.Models
{
    public class IkeaItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Star { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public Type Type { get; set; }
        public string Category { get; set; }
    }
    public enum Type
    {
        New,
        SecondHand
    }
}
