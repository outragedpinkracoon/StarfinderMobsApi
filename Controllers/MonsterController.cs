using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StarfinderMobsApi.Controllers
{
  [Route("api/[controller]")]
  public class MonstersController : Controller
  {
    // GET api/values
    [HttpGet]
    public string Get() {
      return System.IO.File.ReadAllText("data/monsters.json");
    }
  }
}
