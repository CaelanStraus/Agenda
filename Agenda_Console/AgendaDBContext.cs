using Agenda_Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda_Console
{
    internal class AgendaDBContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=AgendaDb;User Id=sa;Password=Your_password123;MultipleActiveResultSets=true");
        }
    }
}