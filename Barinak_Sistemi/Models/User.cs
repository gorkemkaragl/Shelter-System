using System.ComponentModel.DataAnnotations;
namespace Barinak_Sistemi.Models
{
	public class User
	{
        public int userId { get; set; }
        [Required(ErrorMessage ="Boş bırakmayınız")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Boş bırakmayınız")]
        public string userLastName { get; set; }
        [Required(ErrorMessage = "Boş bırakmayınız")]
        public string userPhoneNumber { get; set; }
        [Required(ErrorMessage = "Boş bırakmayınız")]
        public string userEmail { get; set; }

       [Required(ErrorMessage = "Boş bırakmayınız")]
        public string password { get; set; }


    }
}
