using System.ComponentModel.DataAnnotations;
namespace Barinak_Sistemi.Models
{
	public class ShelterUsers
	{
		[Required(ErrorMessage = "boş bırakılamaz")]
		public string name { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public string surName { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public string email { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public int phoneNumber { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public string adress { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public string city { get; set; }
		[Required(ErrorMessage = "boş bırakılamaz")]
		public int salary { get; set; }
		public string gender { get; set; }
		
		public string reason { get; set; }

	}
}
