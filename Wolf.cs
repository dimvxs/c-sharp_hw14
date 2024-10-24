using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class Wolf: Carnivore //австралийский волк
    {
     public override int Power { get; set; } = 10;
     public override string Name { get; set; } = "волк";

    }
}