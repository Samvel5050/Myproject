using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore
{
    public class Table : Material
    {
        public Table(double high, double width, double length, double weight) : base(high, width, length, weight)
        {

        }
        public override void FurnitureManager()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine($"Table ---> high - {_high}, width - {_width}, length - {_length}, weight - {_weight}  ");
        }
    }
}
