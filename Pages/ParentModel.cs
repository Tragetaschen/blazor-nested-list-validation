using System.ComponentModel.DataAnnotations;

namespace NestedListValidation.Pages
{
    public class ParentModel
    {
        [Required]
        [MinLength(1, ErrorMessage = "Not enough")]
        [ValidateComplexType]
        public List<ChildModel> Children { get; set; } = new();
    }
}
