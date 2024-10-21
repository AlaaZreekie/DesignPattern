using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SOLID.InterfaceSegeration
{
    public class Circle : IShape2D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
