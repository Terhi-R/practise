using Microsoft.AspNetCore.Mvc;

using newAddressBook.Models;

namespace newAddressBook.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class AddressesController : ControllerBase
{

    public class Addr
    {
        public Addr()
        {
            Addresses = new List<Address>() {
            new Address() {Id = 1, Street = "Ospelia", StreetNr = 11, PostCode = 1481, City = "Hagan"},
            new Address() {Id = 2, Street = "Nedre Slottsgate", StreetNr = 13, PostCode = 1123, City = "Oslo"},
            new Address() {Id = 3, Street = "Maridalsveien", StreetNr = 54, PostCode = 1222, City = "Oslo"},
        };
        }

        public List<Address> Addresses { get; set; }
    }

    private Addr _ad;

    public AddressesController(Addr addr)
    {
        _ad = addr;
    }

    [HttpGet]
    public List<Address> GetAllAddresses()
    {
        return _ad.Addresses;
    }

    [HttpPost]
    public IActionResult Create(CreateNew createAddress)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var newId = _ad.Addresses.Count + 1;

        var newAddress = new Address()
        {
            Street = createAddress.Street,
            StreetNr = createAddress.StreetNr,
            PostCode = createAddress.PostCode,
            City = createAddress.City,
            Id = newId
        };
        _ad.Addresses.Add(newAddress);
        return CreatedAtAction(nameof(GetAllAddresses), newAddress);
    }
}