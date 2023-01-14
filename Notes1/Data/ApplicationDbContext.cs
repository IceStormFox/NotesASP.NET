using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Notes1.Models;

namespace Notes1.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public DbSet<Note>? Notes { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
