

using Microsoft.EntityFrameworkCore;
using BaseLibrary.Entities;

namespace ServerLibrary.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // DbSets for your entities
    public DbSet<Employee>? Employees { get; set; }
    public DbSet<GeneralDepartment>? GeneralDepartment { get; set; }
    public DbSet<Department>? Department { get; set; }
    public DbSet<Branch>? Branch { get; set; }
    public DbSet<Town>? Town { get; set; }
    public DbSet<ApplicationUser>? ApplicationUser { get; set; }
}
