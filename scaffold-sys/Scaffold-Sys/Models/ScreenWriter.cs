using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SKA_Holding.Models;

[Table("ScreenWriter")]
public partial class ScreenWriter
{
    [Key]
    public int ScreenWriterId { get; set; }

    [StringLength(100)]
    public string ScreenWriterName { get; set; } = null!;

    [StringLength(100)]
    public string ScreenWriterSurname { get; set; } = null!;

    [InverseProperty("ScreenWriter")]
    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
