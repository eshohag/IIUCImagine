using System.ComponentModel.DataAnnotations;

namespace IIUCImagine.Models
{
    public class DoYouKnow
    {
        public int ID { get; set; }
        [Display(Name = "Programing")]

        public string Tittle { get; set; }
    }
}