using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace todoShared;

[Table("Todo")]
public partial class Todo
{
    public string? Kurzbeschreibung { get; set; }

    public string? Beschreibung { get; set; }

    public string? ErstelltAm { get; set; }

    public string? Fälligkeitsdatum { get; set; }

    public long? Priorität { get; set; }

    public long? Status { get; set; }

    [Key]
    public long Id { get; set; }

    [ForeignKey("Priorität")]
    [InverseProperty("Todos")]
    public virtual Priorität? PrioritätNavigation { get; set; }

    [ForeignKey("Status")]
    [InverseProperty("Todos")]
    public virtual Status? StatusNavigation { get; set; }
}
