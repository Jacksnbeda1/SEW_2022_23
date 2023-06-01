using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test3Shared;

[Table("Test")]
public partial class Test
{
    [Column("Test")]
    public long Test1 { get; set; }

    [Key]
    public long Id { get; set; }
}
