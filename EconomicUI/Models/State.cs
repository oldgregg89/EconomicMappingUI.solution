using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EconomicUI.Models
{
  public class State
  {
    public int StateId { get; set; }
    public string Name { get; set; }
    public int GDP { get; set; }
    public string MainExport { get; set; }
    public string MainImport { get; set; }
    public static List<State> GetStates()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<State> stateList = JsonConvert.DeserializeObject<List<State>>(jsonResponse.ToString());

      return stateList;
    }
    public static State SearchStates(string name)
    {
      var apiCallTask = ApiHelper.GetSearchResults(name);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      State state = JsonConvert.DeserializeObject<State>(jsonResponse.ToString());

      return state;
    }

    public static State GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      State state = JsonConvert.DeserializeObject<State>(jsonResponse.ToString());
      
      return state;
    }
  }
}