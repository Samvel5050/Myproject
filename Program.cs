 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Material door = new Door(2.1,0.12,1.2,5);
            door.FurnitureManager();
            Console.WriteLine(new string('_', 58));

            Material table = new Table(1.4,2.4,1.5,10);
            table.FurnitureManager();
            Console.WriteLine(new string('_', 58));

            Material chair = new Chair(1.3,1,0.8,2.5);
            chair.FurnitureManager();
            Console.WriteLine();
            
            List<Material> constructor = new List<Material>();
            constructor.Add(door);
            constructor.Add(table);
            constructor.Add(chair);
            
          
   
        }
    }
 
}
