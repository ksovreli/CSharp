using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SKA_Holding.Models;

[Table("Actor")]
public partial class Actor
{
    [Key]
    public int ActorId { get; set; }

    [StringLength(100)]
    public string ActorName { get; set; } = null!;

    [StringLength(100)]
    public string ActorSurname { get; set; } = null!;

    [ForeignKey("ActorId")]
    [InverseProperty("Actors")]
    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
