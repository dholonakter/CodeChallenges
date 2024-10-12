using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebIdentityScaffold.Areas.Identity.Data;

namespace WebIdentityScaffold.Data;

public class WebIdentityScaffoldContext : IdentityDbContext<WebIdentityScaffoldUser>
{
    public WebIdentityScaffoldContext(DbContextOptions<WebIdentityScaffoldContext> options)
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
