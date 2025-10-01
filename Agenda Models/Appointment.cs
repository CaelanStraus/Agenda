using System.ComponentModel.DataAnnotations;

namespace Agenda_Models
{
    public class Appointment
    {
        private DateTime now = DateTime.Now + new TimeSpan(0, 1, 0);
        private DateTime _from = DateTime.Now + new TimeSpan(1, 0, 0, 0);

        public long Id { get; set; }  

        [Required]
        [Display(Name = "Vanaf")]
        [DataType(DataType.DateTime)]
        public DateTime From
        {
            get => _from;
            set
            {
                if (value < now)
                    _from = now;
                else
                    _from = value;
            }
        }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Tot")]
        public DateTime To { get; set; } = DateTime.Now + new TimeSpan(1, 1, 30, 0);

        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Omschrijving")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Hele dag")]
        public bool AllDay { get; set; } = false;

        [Required]
        [Display(Name = "Aangemaakt")]
        public DateTime Created { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Verwijderd")]
        public DateTime Deleted { get; set; } = DateTime.MaxValue;

        public override string ToString()
        {
            return Id + " Afspraak op " + From + " betreffende " + Title;
        }

        public static List<Appointment> SeedingData()
        {
            var list = new List<Appointment>();
            list.AddRange(
                new Appointment { Title = "-", Deleted = DateTime.Now },
                new Appointment
                {
                    From = DateTime.Now.AddDays(1).AddHours(9),
                    To = DateTime.Now.AddDays(1).AddHours(10),
                    Title = "Afspraak tandarts",
                    Description = "Controle en reiniging",
                    AllDay = false
                },

                new Appointment
                {
                    From = DateTime.Now.AddDays(2).AddHours(14),
                    To = DateTime.Now.AddDays(2).AddHours(15),
                    Title = "Vergadering project X",
                    Description = "Bespreking voortgang en volgende stappen",
                    AllDay = false
                },
                new Appointment
                {
                    From = DateTime.Now.AddDays(3).AddHours(18),
                    To = DateTime.Now.AddDays(3).AddHours(19),
                    Title = "Diner met vrienden",
                    Description = "Gezellig eten en bijpraten",
                    AllDay = false
                }
            );
            return list;
        }
    }
}