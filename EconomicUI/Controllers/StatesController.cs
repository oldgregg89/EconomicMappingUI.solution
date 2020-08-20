using Microsoft.AspNetCore.Mvc;
using EconomicUI.Models;

namespace EconomicUI.Controllers
{
  public class StatesController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      var allStates = State.GetStates();
      return View(allStates);
    }

    // [HttpGet("States")]
    public IActionResult Search(string name)
    {
        var searchedStates = State.SearchStates(name);
        return View(searchedStates);
    }

    // [HttpGet("Details")]
    public IActionResult Details(int id)
    {
      var state = State.GetDetails(id);
      return View(state);
    }

    public IActionResult Edit(int id)
    {
      var state = State.GetDetails(id); 
      return View(state);
    }

    [HttpPost]
    public IActionResult Details(int id, State state)
    {
      state.StateId = id;
      State.Put(state);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      State.Delete(id);
      return RedirectToAction("Index");
    }
  }
}