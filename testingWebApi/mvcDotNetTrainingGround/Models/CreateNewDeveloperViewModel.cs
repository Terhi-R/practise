using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvcDotNetTrainingGround.Models;

public class CreateNewDeveloperViewModel
{
    [DisplayName("Developer Name")]
    [Required]
    public string? Name { get; set; }

    [DisplayName("Email Address")]
    [Required]
    [EmailAddress]
    public string? Email { get; set; }

}