using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;

namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class DevelopersController : ControllerBase
{
    public class Db
    {
        public Db()
        {
            Developers = new List<Developer> {
            new Developer() { Id = 1, Name = "Miele", Email = "miele@student.com"},
            new Developer() { Id = 2, Name = "Matte", Email = "matte@student.com"},
        };
        }
        public List<Developer> Developers { get; set; }

    }

    private Db _db;
    public DevelopersController(Db db)
    {
        _db = db;
    }

    public List<Developer> DeveloperResponse()
    {
        return _db.Developers;
    }

    [HttpGet]
    public List<Developer> GetAllDevelopers()
    {
        return DeveloperResponse();
    }

    /* 
    //for getting only 1 certain ID
        [HttpGet("Id")]
        public int GetFirstId()
        {
            return _db[0].Id;
        }
        */
    [HttpGet("{id}")]
    public Developer? GetWantedId(int id)
    {
        return DeveloperResponse().Find(d => d.Id == id);
    }

    //For looping through and choosing which Id to look at
    /*
        [HttpGet("{id}")]
        public Developer? GetWantedId(int id)
        {
            return _db.Find(d => d.Id == id);
        }
    */

    [HttpPost]
    public IActionResult CreateNewDeveloper(CreateDeveloperRequest request)
    {
        var nextId = DeveloperResponse().Count + 1;
        var newDev = new Developer()
        {
            Id = nextId,
            Name = request.Name,
            Email = request.Email,
        };

        DeveloperResponse().Add(newDev);

        return CreatedAtAction(nameof(GetWantedId), new { id = nextId }, newDev);
    }




}
