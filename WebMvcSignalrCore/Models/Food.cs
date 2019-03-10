namespace FoodOrderSignalrCore.Models
{
    public sealed class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }
}
