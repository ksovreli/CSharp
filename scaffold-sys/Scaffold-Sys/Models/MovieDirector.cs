using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SKA_Holding.Models;

[Table("MovieDirector")]
public partial class MovieDirector
{
    [Key]
    public int DirectorId { get; set; }

    [StringLength(100)]
    public string DirectorName { get; set; } = null!;

    [StringLength(100)]
    public string DirectorSurname { get; set; } = null!;

    [InverseProperty("Director")]
    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
