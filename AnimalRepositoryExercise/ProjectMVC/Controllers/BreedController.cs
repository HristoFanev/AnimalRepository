using DataAccess.Implementation;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace ProjectMVC.Controllers
{
    public class BreedController : Controller
    {
        Breed breed = new Breed();
        AnimalRepositoryImplementation<Breed> b = new AnimalRepositoryImplementation<Breed>();
        public IActionResult Index()
        {
            return View(b.GetAll());
        }
    }
}
