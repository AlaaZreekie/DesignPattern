using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Template
{
    public class Tea : IBeverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing tea for 3 minutes");
        }

        private void AddCondiments()
        {
            Console.WriteLine("Adding lemon to tea");
        }
    }
}
