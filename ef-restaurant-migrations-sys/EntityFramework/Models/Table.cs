using EntityFramework.Enum;

namespace EntityFramework.Models
{
    internal class Table
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; } = string.Empty;
        public int MyProperty { get; set; }
        public TableStatus Status { get; set; }
        public List<Reservation>? Reservations { get; set; }
    }
}
