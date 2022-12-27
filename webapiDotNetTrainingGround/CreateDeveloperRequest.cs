using System.ComponentModel.DataAnnotations;

public class CreateDeveloperRequest
{
    [Required(ErrorMessage = "The 'Email' must be added in the request body")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "The 'Email' must be added in the request body")]
    public string? Email { get; set; }
}