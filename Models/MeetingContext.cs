using Microsoft.EntityFrameworkCore;

namespace MøtePlanleggerClI.Models
{
  public class MeetingContext : DbContext
  {
    public DbSet<Person> People { get; set; } 
    public DbSet<Meeting> Meetings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MeetingPlannerDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
  }
}