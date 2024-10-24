using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class Lion: Carnivore
    {
        public override int Power { get; set; } = 10;
        public override string Name { get; set; } = "лев";
    }
}