using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Observe
{
    public class BarRender: IObserver
    {


        //old
        public void Render(List<int> values) 
        {
            Console.WriteLine("Rendering bar char with new values");
        }
        //new
        private DataSourse _dataSourse;
        public BarRender(DataSourse dataSourse)
        {
            _dataSourse = dataSourse;   
        }
        public void Update()
        {
            Console.WriteLine("Rendering bar char with new values");
        }
    }
}
