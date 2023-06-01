using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HUE06Shared;

public partial class Hue06Context : DbContext
{
    public Hue06Context()
    {
    }

    public Hue06Context(DbContextOptions<Hue06Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TodoListe> TodoListes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Filename=db/HUE06.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
