using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SKA_Holding.Models;

[Table("Genre")]
public partial class Genre
{
    [Key]
    public int GenreId { get; set; }

    [StringLength(100)]
    public string GenreName { get; set; } = null!;

    public virtual ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
}
