using EntityFramework.Enum;

namespace EntityFramework.Models
{
    internal class MenuItem
    {
        public uint Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public MenuCategory Category { get; set; }
        public bool IsAvailable { get; set; }
    }
}
