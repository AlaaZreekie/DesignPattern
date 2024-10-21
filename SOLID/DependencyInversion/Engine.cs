using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SOLID.DependencyInversion
{
    public class Engine : IEngine
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Statr()
        {
            Console.WriteLine("Engine Started");
        }
    }
}
