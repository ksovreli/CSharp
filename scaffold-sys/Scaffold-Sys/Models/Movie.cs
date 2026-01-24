using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SKA_Holding.Models;

[Table("Movie")]
public partial class Movie
{
    [Key]
    public int MovieId { get; set; }

    public int DirectorId { get; set; }

    public int ScreenWriterId { get; set; }

    [StringLength(100)]
    public string Title { get; set; } = null!;

    public int? ReleaseYear { get; set; }

    public int? Duration { get; set; }

    public string? Description { get; set; }

    [ForeignKey("DirectorId")]
    [InverseProperty("Movies")]
    public virtual MovieDirector Director { get; set; } = null!;

    [InverseProperty("Movie")]
    public virtual ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();

    [InverseProperty("Movie")]
    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    [InverseProperty("Movie")]
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    [ForeignKey("ScreenWriterId")]
    [InverseProperty("Movies")]
    public virtual ScreenWriter ScreenWriter { get; set; } = null!;

    [ForeignKey("MovieId")]
    [InverseProperty("Movies")]
    public virtual ICollection<Actor> Actors { get; set; } = new List<Actor>();
}
