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
        public IActionResult Search(string name)
        {
          var searchedStates = State.SearchStates(name);
          return View(searchedStates);
        }

        public IActionResult Details(int id)
        {
          var state = State.GetDetails(id);
          return View(state);
        }
    }
}