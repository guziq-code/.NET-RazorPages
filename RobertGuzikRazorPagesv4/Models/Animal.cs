using System.ComponentModel.DataAnnotations;
namespace RobertGuzikRazorPagesv4.Models
{
    public class Animal
    {
        [Display(Name="id")]
        public int AnimalId { get; set; }

		[StringLength(60, MinimumLength =3 )]
        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Required]
        [Display(Name="name")]
		public String Name { get; set; }

		[Display(Name = "birth date")]
        [DataType(DataType.Date)]
		public DateTime BirthDate { get; set; }
    }
}
