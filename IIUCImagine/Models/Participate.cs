using System.ComponentModel.DataAnnotations;

namespace IIUCImagine.Models
{
    public class Participate
    {
        public int ID { get; set; }
        [Display(Name = "Participate ImagineCup")]
        public string Tittle { get; set; }

    }
}