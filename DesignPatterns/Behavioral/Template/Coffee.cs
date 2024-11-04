using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Template
{
    public class Coffee : IBeverage
    {
        public void Prepare()
        {
            Brew(); ;
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing coffee for 5 minutes");
        }

        private void AddCondiments()
        {
            Console.WriteLine("Adding sugar to coffee");
        }
    }
}
