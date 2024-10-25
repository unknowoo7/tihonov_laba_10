using Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace laba_10.Models
{
  public class DatabaseContext : DbContext
  {
    public DbSet<Project> Projects { get; set; }
    public DbSet<Manager> Managers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Project>().HasKey(p => p.Id);
      modelBuilder.Entity<Manager>().HasKey(p => p.Id);

      modelBuilder.Entity<Project>()
             .HasOne(p => p.Manager)
             .WithMany(pc => pc.Projects)
             .HasForeignKey(p => p.ManagerId);
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }


  }
}
