using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SOLID.InterfaceSegeration
{
    public class Sphere : IShape3D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return 4 * Math.PI * Radius * Radius;
        }

        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
