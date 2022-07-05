using System.ComponentModel.DataAnnotations;

namespace NestedListValidation.Pages
{
    public class ChildModel : IValidatableObject
    {
        public string? Name { get; set; }
        public string? AlternativeName { get; set; }
        
        [Required]
        public string? Required { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(AlternativeName))
            {
                yield return new ValidationResult("At least one must be set");
            }
        }
    }
}
