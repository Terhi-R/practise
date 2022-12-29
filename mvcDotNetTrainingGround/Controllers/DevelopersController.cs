using Microsoft.AspNetCore.Mvc;
using mvcDotNetTrainingGround.Models;
namespace mvcDotNetTrainingGround.Controllers;

public class DevelopersController : Controller
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

    public IActionResult Index()
    {
        return View(_db.Developers);
    }

    public IActionResult Details(int id)
    {
        return View(_db.Developers.Find(d => d.Id == id));
    }


    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreateNewDeveloperViewModel viewModel)
    {

        var nextId = _db.Developers.Count + 1;
        if (ModelState.IsValid)
        {

            var developerToAdd = new Developer()
            {
                Id = nextId,
                Name = viewModel.Name,
                Email = viewModel.Email,
            };

            _db.Developers.Add(developerToAdd);
        }

        return RedirectToAction(nameof(Index));

    }
}