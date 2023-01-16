using DataAccess.Implementation;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace ProjectMVC.Controllers
{
    public class AnimalController : Controller
    {
        Animal animal = new Animal();
        AnimalRepositoryImplementation<Animal> a = new AnimalRepositoryImplementation<Animal>();
        public IActionResult Index()
        {
            return View(a.GetAll());
        }
    }
}
