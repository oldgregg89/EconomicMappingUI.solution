using Microsoft.AspNetCore.Mvc;
using EconomicUI.Models;

namespace EconomicMappingUI.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
          var allStates = State.GetStates();
          return View(allStates);
        }
    }
}