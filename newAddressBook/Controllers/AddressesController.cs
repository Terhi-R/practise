using Microsoft.AspNetCore.Mvc;
using newAddressBook.Models;

namespace newAddressBook.Controllers;


public class AddressesController : Controller
{

    public class Addr
    {
        public Addr()
        {
            Addresses = new List<Address>() {
            new Address() {Street = "Ospelia", StreetNo = 11, PostCode = 1481, City = "Hagan"},
            new Address() {Street = "Ospelia", StreetNo = 12, PostCode = 1481, City = "Hagan"},
            new Address() {Street = "Ospelia", StreetNo = 13, PostCode = 1481, City = "Hagan"},
        };
        }

        public List<Address> Addresses { get; set; }
    }

    private Addr _ad;

    public AddressesController(Addr addr)
    {
        _ad = addr;
    }

    public IActionResult Index()
    {
        return View(_ad.Addresses);
    }
    public IActionResult CreateNew()
    {
        return View();
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
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Delete(int nr)
    {
        var chosenAddress = _ad.Addresses.Find(a => a.StreetNo == nr);

        return RedirectToAction(nameof(Index));
    }
}