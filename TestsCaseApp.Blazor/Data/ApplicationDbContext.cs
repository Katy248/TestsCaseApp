using Microsoft.EntityFrameworkCore;
using TestsCaseApp.Blazor.Models;

namespace TestsCaseApp.Blazor.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<TestCase> TestCases { get; set; }
    public DbSet<TestCaseResult> TestCaseResults { get; set; }
    public DbSet<TestCaseStep> TestCaseSteps { get; set; }
    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<TestCaseResult>()
            .HasOne(tcr => tcr.TestCase)
            .WithOne(tc => tc.Result)
            .IsRequired();
        
        modelBuilder
            .Entity<TestCase>()
            .HasOne(tc => tc.Result)
            .WithOne(tr => tr.TestCase)
            .IsRequired(false);
        base.OnModelCreating(modelBuilder);
    }*/
}