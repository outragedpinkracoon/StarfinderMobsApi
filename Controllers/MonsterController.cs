using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace StarfinderMobsApi.Controllers
{
  [Route("api/[controller]")]
  public class MonstersController : Controller
  {
    // GET api/values
    [HttpGet]
    public string Get() {
      string json = System.IO.File.ReadAllText("data/monsters.json");
      return new Monsters(json).Sort().ToString();
    }
  }
}
