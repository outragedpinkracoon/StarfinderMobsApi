using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace StarfinderMobsApi.Controllers
{
  [Route("api/[controller]")]
  public class MonstersController : Controller
  {
    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get() => new string[] { "monster1", "monster2" };
  }
}
