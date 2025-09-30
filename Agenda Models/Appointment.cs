using System.ComponentModel.DataAnnotations;

namespace Agenda_Models
{
    public class Appointment
    {
        public long Id { get; set; }

        [Required]
        [Display(Name = "Vanaf")]
        [DataType(DataType.DateTime)]
        [Range(typeof(DateTime), "2025-01-01", "9999-12-31")]
        public DateTime From { get; set; } = DateTime.Now + new TimeSpan(1, 0, 0, 0);
        [Required]
        [Display(Name = "Tot")]
        [DataType(DataType.DateTime)]
        public DateTime To { get; set; } = DateTime.Now + new TimeSpan(1, 0, 0, 0);
        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Beschrijving")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Hele dag")]
        public bool IsAllDay { get; set; } = false;
        [Required]
        [Display(Name = "Aangemaakt op")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        [Display(Name = "Verwijderd")]
        public DateTime DeletedAt { get; set; } = DateTime.MaxValue;
    }
}