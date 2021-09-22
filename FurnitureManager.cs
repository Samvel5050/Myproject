using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore
{
    public class FurnitureManager
    {
        public void Work(List<Material> materials)
        {
            for (int i = 0; i < materials.Count; i++)
            {
                materials[i].FurnitureManager();
            }
        }
    }
}
