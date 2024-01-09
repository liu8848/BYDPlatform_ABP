using BYDPlatform.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace BYDPlatform.EntityFrameworkCore.EntityFrameWorkCore;

[ConnectionStringName("Default")]
public class BYDPlatformDbContext:AbpDbContext<BYDPlatformDbContext>
{
    public DbSet<User> Users { get; set; }

    public BYDPlatformDbContext(DbContextOptions<BYDPlatformDbContext> options)
        :base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>();
    }
}