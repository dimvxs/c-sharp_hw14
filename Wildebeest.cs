using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class Wildebeest: Herbivore
    {
        public override string Name { get; set; } = "антилопа гну";
        public override double Weight { get; set; } = 10;
    }
}