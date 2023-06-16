using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace todoShared;

[Table("Priorität")]
public partial class Priorität
{
    [Column("Priorität")]
    public string? Priorität1 { get; set; }

    [Key]
    public long Id { get; set; }

    [InverseProperty("PrioritätNavigation")]
    public virtual ICollection<Todo> Todos { get; set; } = new List<Todo>();
}
