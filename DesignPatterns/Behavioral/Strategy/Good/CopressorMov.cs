using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Strategy.Good
{
    internal class CopressorMov : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Using MOV.");
        }
    }
}
