using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public abstract class Continent
    {
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
    }
}