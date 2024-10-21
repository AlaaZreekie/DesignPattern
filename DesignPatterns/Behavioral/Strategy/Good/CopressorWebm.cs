using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Strategy.Good
{
    internal class CopressorWebm : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Using WBEM.");
        }
    }
}
