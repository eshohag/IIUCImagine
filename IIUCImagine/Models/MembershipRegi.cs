using System.ComponentModel.DataAnnotations;

namespace IIUCImagine.Models
{
    public class MembershipRegi
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Full Name")]

        public string Name { get; set; }
        [Required]
        [Display(Name = "Contact No ")]
        public string ContactNo { get; set; }
        [Required]
        [Display(Name = "Student ID ")]
        public string StudentID { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        [Required]
        //[Display(Name = "Do you know about C#/VB/F# Programing Language?")]
        public int DoYouKnowID { get; set; }
        public virtual DoYouKnow DoYouKnow { get; set; }
        [Required]
        public int ParticipateID { get; set; }
        public virtual Participate Participate { get; set; }
    }
}