using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MVC.Entitties;

namespace MVC.Contexts;

public class Db : DbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<Resource> Resources { get; set; }

    public DbSet<UserResource> UserResources { get; set; }

    public Db(DbContextOptions Options) : base(Options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserResource>().HasKey(e => new { e.UserId, e.ResourceId });
    }


}
