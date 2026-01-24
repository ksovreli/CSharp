using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SKA_Holding.Models;

[Table("MovieGenre")]
public partial class MovieGenre
{
    [Key]
    public int MovieGenreId { get; set; }

    public int MovieId { get; set; }

    public int GenreId { get; set; }

    [ForeignKey("GenreId")]
    [InverseProperty("MovieGenres")]
    public virtual Genre Genre { get; set; } = null!;

    [ForeignKey("MovieId")]
    [InverseProperty("MovieGenres")]
    public virtual Movie Movie { get; set; } = null!;
}
