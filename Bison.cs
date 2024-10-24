using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class Bison: Herbivore
    {
        public override string Name { get; set; } = "бизон";
        public override double Weight { get; set; } = 10;
    }
}