using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Country")]
        [MaxLength(100, ErrorMessage = "The field {0} cannot have more than {1} characters!")]
        [Required(ErrorMessage = "The field {0} is mandatory!")]
        public string Name { get; set; } = null!;
    }
}