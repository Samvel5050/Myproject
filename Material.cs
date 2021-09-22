using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore

{
    public class Material
    {
        public Material(double high,double width,double length,double weight )
        {
            _high = high;
            _width = width;
            _length = length;
            _weight = weight;
        }

        public double _high;
        public double _width;
        public  double _length;
        public double _weight;

        public virtual void FurnitureManager()
        {
           

        }
    }
}
