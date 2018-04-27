using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

class Monsters {
  private JArray _all { get; set; }
  public Monsters(string json) {
    _all = JArray.Parse(json);
  }

  public Monsters Sort() {
    _all = new JArray(
      _all.OrderBy(obj => obj["exp"])
          .ThenBy(obj => obj["name"])
    );
    return this;
  }

  public override string ToString() {
    return _all.ToString();
  }
}
