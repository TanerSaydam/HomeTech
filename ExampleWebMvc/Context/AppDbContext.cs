using Microsoft.EntityFrameworkCore;

namespace ExampleWebMvc.Context;

public class AppDbContext : DbContext //DbContextOptionsBuilder .Options
{
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("");
    //}
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}
