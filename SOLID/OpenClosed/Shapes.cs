using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SOLID.OpenClosed
{
    public abstract class Shapes
    {
        public abstract double CalculateArea();
    }

    public interface IShape
    {
        double CalculateArea();
    }
}
