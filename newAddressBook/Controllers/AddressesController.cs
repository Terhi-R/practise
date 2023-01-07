using System.Data;
using System.Diagnostics;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using newAddressBook.Models;
using Newtonsoft.Json;

namespace newAddressBook.Controllers;


public class AddressesController : Controller
{

    string apiURL = "https://localhost:7246/api/";

    public async Task<IActionResult> Index()
    {
        DataTable dt = new DataTable();
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri(apiURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage getData = await client.GetAsync("Addresses");
            if (getData.IsSuccessStatusCode)
            {
                string results = getData.Content.ReadAsStringAsync().Result;
                dt = JsonConvert.DeserializeObject<DataTable>(results);
            }
            else
            {
                Console.WriteLine("Error calling webAPI");
            }
        }
    }
    public IActionResult CreateNew()
    {
        return View();
    }



    /*

      public IActionResult AddressId(int id)
    {
        return View(_ad.Addresses.Find(a => a.Id == id));
    }

        [HttpPost]
        public IActionResult Create(CreateNew createAddress)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var nextId = _ad.Addresses.Count + 1;

            var newAddress = new Address()
            {
                Id = nextId,
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
        }*/
}