using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;

namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class DevelopersController : ControllerBase
{
    private List<Developer> _db;
    public DevelopersController()
    {
        _db = new List<Developer>()
        {
            new Developer() { Id = 1234, Name = "Miele", Email = "miele@student.com"},
            new Developer() { Id = 1235, Name = "Matte", Email = "matte@student.com"}.
    };
    }

    [HttpGet]
    public List<Developer> GteAllDevs()
    {
        return _db;
    }

}