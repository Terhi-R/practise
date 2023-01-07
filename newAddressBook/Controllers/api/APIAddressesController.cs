using Microsoft.AspNetCore.Mvc;
using newAddressBook.Models;

namespace newAddressBook.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class APIAddressesController : ControllerBase
{

    public class Addr
    {
        public Addr()
        {
            Addresses = new List<Address>() {
            new Address() {Street = "Ospelia", StreetNo = 11, PostCode = 1481, City = "Hagan"},
            new Address() {Street = "Nedre Slottsgate", StreetNo = 13, PostCode = 1123, City = "Oslo"},
            new Address() {Street = "Maridalsveien", StreetNo = 54, PostCode = 1222, City = "Oslo"},
        };
        }

        public List<Address> Addresses { get; set; }
    }

    private Addr _ad;

    public APIAddressesController(Addr addr)
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

        var newAddress = new Address()
        {
            Street = createAddress.Street,
            StreetNo = createAddress.StreetNo,
            PostCode = createAddress.PostCode,
            City = createAddress.City
        };

        _ad.Addresses.Add(newAddress);
        return CreatedAtAction(nameof(GetAllAddresses), newAddress);
    }



}