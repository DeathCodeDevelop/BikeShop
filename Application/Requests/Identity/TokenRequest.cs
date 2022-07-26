using System.ComponentModel.DataAnnotations;

namespace Application.Requests.Identity
{
	public class TokenRequest
	{
		[Required]
		public string Id { get; set; }

		[Required]
		public string Username { get; set; }
	}
}
