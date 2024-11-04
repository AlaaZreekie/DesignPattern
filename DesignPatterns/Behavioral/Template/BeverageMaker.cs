using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Template
{
    public class BeverageMaker
    {
        private IBeverage _beverage;

        public BeverageMaker(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public void SetBeverage(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public void MakeBeverage()
        {
            BoilWater();
            PourIntoCup();
            _beverage.Prepare();
        }

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
