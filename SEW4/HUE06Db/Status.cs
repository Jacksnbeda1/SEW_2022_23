using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace todoShared;

[Table("Status")]
public partial class Status
{
    [Column("Status")]
    public string? Status1 { get; set; }

    [Key]
    public long Id { get; set; }

    [InverseProperty("StatusNavigation")]
    public virtual ICollection<Todo> Todos { get; set; } = new List<Todo>();
}
