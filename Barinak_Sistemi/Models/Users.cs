using System.ComponentModel.DataAnnotations;
namespace Barinak_Sistemi.Models
{
	public class Users
	{
		[Required(ErrorMessage = "boş bırakılamaz")]
		public string name { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public string lastName { get; set; }

		[Required(ErrorMessage ="boş bırakılamaz")]
		public string email { get; set; }
        [Required(ErrorMessage = "boş bırakılamaz")]
        public string password { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public int phoneNumber { get; set; }

	}
}
