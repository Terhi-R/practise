using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace newAddressBook.Models;

public class CreateNew
{
    [Required]
    public string? Street { get; set; }
    [Required]
    public int StreetNr { get; set; }
    [Required]
    public int? PostCode { get; set; }
    [Required]
    public string? City { get; set; }

    public int? Id { get; set; }
}