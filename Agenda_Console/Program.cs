using Agenda_Console;

using (var context = new AgendaDBContext())
{
    AgendaDBContext.Seeder(context);

    var appointments = context.Appointments.ToList();
    foreach (var appointment in appointments)
    {
        Console.WriteLine(appointment);
    }
}
