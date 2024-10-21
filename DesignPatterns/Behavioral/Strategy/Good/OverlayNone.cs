using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Strategy.Good
{
    public class OverlayNone : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Using None");
        }
    }
}
