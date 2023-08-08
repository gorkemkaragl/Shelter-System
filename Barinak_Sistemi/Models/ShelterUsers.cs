using System.ComponentModel.DataAnnotations;
namespace Barinak_Sistemi.Models
{
	public class ShelterUsers
	{
		[Key]
		public int shelterId { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public string shelterName { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public string shelterSurName { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public string email { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public string shelterPhoneNumber { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]

		public string shelterGender { get; set; }
		
		public string reason { get; set; }

	}
}
