using System.ComponentModel.DataAnnotations;
namespace Simple_Static_Website.Models
{
	public enum House { Gryffindor, Hufflepuff, Slytherin, Ravenclaw }

	public class LoginViewModel
	{
		[Required(ErrorMessage ="Please select your Hogwarts House.")]
		public House House { get; set; }

		[Required(ErrorMessage = "Please enter the correct secret phrase to pass through.")]
		public String Password { get; set; }

		[Required(ErrorMessage = "Please agree to solemnly swear that you are up to no good.")]
		public Boolean? Agree { get; set; }
	}
}

