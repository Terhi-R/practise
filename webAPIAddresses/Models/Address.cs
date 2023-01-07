using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace newAddressBook.Models;

public class Address
{
    public string? Street { get; set; }

    public int StreetNr { get; set; }

    public int? PostCode { get; set; }

    public string? City { get; set; }

    public int? Id { get; set; }
}