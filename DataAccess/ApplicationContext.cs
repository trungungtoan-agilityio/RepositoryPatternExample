using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class ApplicationContext(DbContextOptions<ApplicationContext> options, DbSet<Developer> developers,
        DbSet<Project> projects)
    : DbContext(options)
{
    public DbSet<Developer> Developers { get; set; } = developers;
    public DbSet<Project> Projects { get; set; } = projects;
}