using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore
{
    public class Door : Material
    {
        public Door(double high, double width, double length, double weight) :base(high,width,length,weight)
        {

        }
        public override void FurnitureManager()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Door ---> high - {_high}, width - {_width}, length - {_length}, weight - {_weight}  ");
        }
    }
}
