using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static System.Console;

namespace hw
{
    public abstract class Herbivore
    {
        public abstract double Weight { get; set; }
        public abstract string Name { get; set; }
        public bool Life { get; set; } = true;

        public void EatGrass(){
            Weight += 10;
        }

        public void Status(){
            if(Life){
                Write("с " + Name + " всё хорошо \n");
            }
            else{
                Write(Name + " сьеден \n");
            }
        }
        
    }
}