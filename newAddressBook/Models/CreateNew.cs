using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace newAddressBook.Models;

public class CreateNew
{
    [Required]
    public string? Street { get; set; }
    [Required]
    public int StreetNo { get; set; }
    [Required]
    public string? City { get; set; }
    [Required]
    public int? PostCode { get; set; }
    [Required]
    public int? Id { get; set; }

}