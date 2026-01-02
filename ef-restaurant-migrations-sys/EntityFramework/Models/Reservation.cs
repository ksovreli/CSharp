using EntityFramework.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models
{
    internal class Reservation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhone { get; set; } = string.Empty;
        public DateTime ReservationDate { get; set; }
        public uint NumberOfGuests { get; set; }
        public string SpecialRequests { get; set; } = string.Empty;
        public ReservationStatus Status { get; set; }

        [ForeignKey("Table")]
        public int TableId { get; set; }
        public Table? Table { get; set; }

        [ForeignKey("Waiter")]
        public int WaiterId { get; set; }
        public Waiter? Waiter { get; set; }
    }
}
