using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw
{
    public abstract class Carnivore
    {
        public abstract int Power { get; set; }
        public abstract string Name { get; set; }

        public void Eat(Herbivore obj){
            if(obj.Weight < Power){
              Power += 10;
              obj.Life = false;
              Write(Name + " сьел " + obj.Name + "/n");

            }
            else{
                Power -= 10;
                Write("сила уменьшилась на 10 \n");
            }
        
        }
    }
}