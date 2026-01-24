using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SKA_Holding.Models;

public partial class Review
{
    [Key]
    public int ReviewId { get; set; }

    public int UserId { get; set; }

    public int MovieId { get; set; }

    public string Content { get; set; } = null!;

    public DateOnly? PublishedAt { get; set; }

    [ForeignKey("MovieId")]
    [InverseProperty("Reviews")]
    public virtual Movie Movie { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Reviews")]
    public virtual User User { get; set; } = null!;
}
