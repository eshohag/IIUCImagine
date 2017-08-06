using System.ComponentModel.DataAnnotations;

namespace IIUCImagine.Models
{
    public class Department
    {
        public int ID { get; set; }
        [Display(Name = "Department Name")]

        public string Tittle { get; set; }
    }
}