using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class NorthAmerica: Continent
    {
          public override Herbivore CreateHerbivore()
    {
        return new Wildebeest();
    }

    public override Carnivore CreateCarnivore()
    {
        return new Lion();
    }
    }
}