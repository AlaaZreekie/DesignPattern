using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Template.Abstact
{
    public abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            PourIntoCup();
            Brew();
            AddCondiments();
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine("Bowling water");
        }

        private void PourIntoCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }   
}
