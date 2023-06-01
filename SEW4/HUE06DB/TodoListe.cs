using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HUE06Shared;

[Table("TODO-Liste")]
public partial class TodoListe
{
    public string Kurzbeschreibung { get; set; } = null!;

    public string? Beschreibung { get; set; }

    public string ErstelltAm { get; set; } = null!;

    public string Fälligkeitsdatum { get; set; } = null!;

    public string Priorität { get; set; } = null!;

    public string Status { get; set; } = null!;

    [Key]
    [Column("ID")]
    public long Id { get; set; }
}
