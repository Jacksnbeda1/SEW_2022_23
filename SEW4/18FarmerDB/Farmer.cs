using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FarmerShared;

[Table("Farmer")]
public partial class Farmer
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("firstname")]
    public string Firstname { get; set; } = null!;

    [Column("lastname")]
    public string Lastname { get; set; } = null!;

    [Column("address")]
    public string Address { get; set; } = null!;

    [Column("birthday")]
    public string Birthday { get; set; } = null!;

    [Column("lfbisid")]
    public string? Lfbisid { get; set; }

    [InverseProperty("Farmer")]
    public virtual ICollection<Field> Fields { get; set; } = new List<Field>();
}
