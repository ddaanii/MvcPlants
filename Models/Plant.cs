using System.ComponentModel.DataAnnotations;
using static System.Net.WebRequestMethods;
using System.Runtime.InteropServices;

namespace MvcPlants.Models
{
	public class Plant
	{
		public int Id { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Warning: The Name is not valid. Please ensure you use only letters (uppercase or lowercase), spaces, and periods.")]
		[Required]
		public string? Name { get; set; }

		[Required]
		public string? ImgPath { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Warning: The Species is not valid. Please ensure you use only letters (uppercase or lowercase) and spaces")]
		public string? Family { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Warning: The Species is not valid. Please ensure you use only letters (uppercase or lowercase) and spaces")]
		public string? Genus { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Warning: The Species is not valid. Please ensure you use only letters (uppercase or lowercase) and spaces")]
		public string? Species { get; set; }

		[MinLength(3)]
		[RegularExpression(@"^[a-zA-Z.\s]+$", ErrorMessage = "Warning: The Origin is not valid. Please ensure you use only letters (uppercase or lowercase), spaces, and periods.")]
		[Required]
		public string? Origin { get; set; }
	}
}
