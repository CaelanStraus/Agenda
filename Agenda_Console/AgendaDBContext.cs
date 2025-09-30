using Microsoft.EntityFrameworkCore;

namespace Agenda_Console
{
    internal class AgendaDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=AgendaDb;User Id=sa;Password=Your_password123;MultipleActiveResultSets=true");
        }
    }
}