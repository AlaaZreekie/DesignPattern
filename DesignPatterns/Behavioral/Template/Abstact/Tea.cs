using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Template.Abstact
{
    public class Tea : Beverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon to tea");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brew for 3 minutes");
        }
    }
}
