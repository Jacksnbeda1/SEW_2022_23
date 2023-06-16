using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _23WebApplicationWithAuthentifactionPages.Data;

public class _23WebApplicationWithAuthentifactionPagesContext : IdentityDbContext<IdentityUser>
{
    public _23WebApplicationWithAuthentifactionPagesContext(DbContextOptions<_23WebApplicationWithAuthentifactionPagesContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
