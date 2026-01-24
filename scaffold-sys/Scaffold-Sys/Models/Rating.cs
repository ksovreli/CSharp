using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SKA_Holding.Models;

[Table("Rating")]
[Index("UserId", "MovieId", Name = "UQ__Rating__A335E50C3E2662FC", IsUnique = true)]
public partial class Rating
{
    [Key]
    public int RatingId { get; set; }

    public int UserId { get; set; }

    public int MovieId { get; set; }

    public int? Score { get; set; }

    public DateOnly? RatedAt { get; set; }

    [ForeignKey("MovieId")]
    [InverseProperty("Ratings")]
    public virtual Movie Movie { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Ratings")]
    public virtual User User { get; set; } = null!;
}
