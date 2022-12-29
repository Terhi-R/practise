using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace mvcDotNetTrainingGround.Models;

public class Developer
{
    [Required(ErrorMessage = "Id is required.")]
    public int? Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    public string? Email { get; set; }

}