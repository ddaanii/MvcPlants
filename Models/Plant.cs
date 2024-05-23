using System.ComponentModel.DataAnnotations;
using static System.Net.WebRequestMethods;
using System.Runtime.InteropServices;

namespace MvcPlants.Models
{
    public class Plant
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? ImgPath { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string? Family { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string? Genus { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string? Species { get; set; }

        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z.\s]+$")]
        [Required]
        public string? Origin { get; set; }
    }
}
