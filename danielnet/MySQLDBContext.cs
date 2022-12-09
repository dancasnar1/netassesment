using Microsoft.EntityFrameworkCore;

namespace dotnet;
public class MySQLDBContext : DbContext
{
    public DbSet<Owner> Owner { get; set; }
    public DbSet<Vehicle> Vehicle { get; set; }
    public DbSet<Claim> Claim { get; set; }
    public MySQLDBContext(DbContextOptions<MySQLDBContext> options) : base(options) { }
} 