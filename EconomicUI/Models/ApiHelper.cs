using System.Threading.Tasks;
using RestSharp;

namespace EconomicUI.Models
{
  class ApiHelper
  {
    //Getting all the states
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"states", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    //Searching for a specific state
    public static async Task<string> GetSearchResults(string name)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"states/states/?name={name}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    //Details for state
    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"states/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    //Post a new state
    public static async Task Post(string newState)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"states", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newState);
      var response = await client.ExecuteTaskAsync(request);
    }
    
    //Put for the state
    public static async Task Put(int id, string newState)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"states/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newState);
      var response = await client.ExecuteTaskAsync(request);
    }

    // Delete for the state
    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"states/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}