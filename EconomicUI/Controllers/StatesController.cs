using Microsoft.AspNetCore.Mvc;
using EconomicUI.Models;

namespace EconomicUI.Controllers
{
    public class StatesController : Controller
    {
        public IActionResult Index()
        {
          var allStates = State.GetStates();
          return View(allStates);
        }
    }
}