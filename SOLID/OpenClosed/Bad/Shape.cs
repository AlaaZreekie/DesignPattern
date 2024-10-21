using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SOLID.OpenClosed.Bad
{
    public class Shape
    {
        public ShapeType shapeType { get; set; }
        public double Radius { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double CalculateArea()
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    {
                        return Math.PI * Math.Pow(Radius, 2);
                    }
                case ShapeType.Rectangle:
                    {
                        return Width * Length;
                    }
                default:
                    {
                        throw new Exception("We do not support this shape");
                    }
            }
        }
    }
}
