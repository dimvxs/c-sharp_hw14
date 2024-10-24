using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw
{
    public class AnimalWorld
    {
        private Herbivore herb;
        private Carnivore carn;


        public AnimalWorld(Continent continent){
herb = continent.CreateHerbivore();
carn = continent.CreateCarnivore();
        }


        public void MealsHerbivores(){
           Write($"{herb.Name} ест травку");
           herb.EatGrass();
           WriteLine($"вес {herb.Name}: {herb.Weight} кг.");
        }


        public void NutritionCarnivores(){
           Write($"{carn.Name} пытается сьесть {herb.Name}" );
           carn.Eat(herb);
           WriteLine($"Сила {carn.Name}: {carn.Power}");
           herb.Status();
        }
    }
}