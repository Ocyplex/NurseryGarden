using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NurseryGarden.Models
{
	public class UserModel
	{
		public int Id { get; set; }

		[Required]
		[DisplayName ("UserName")]
		public string UserName { get; set; }

		[Required]
		[DataType (DataType.EmailAddress)]
		[DisplayName ("Email")]
		public string Email { get; set; }

		[Required]
		[DataType (DataType.Password)]
		[DisplayName("Password")]		
		public string Password{ get; set; }
	}
}
