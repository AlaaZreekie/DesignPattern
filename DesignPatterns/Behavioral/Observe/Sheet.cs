using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Observe
{
    public class Sheet: IObserver
    {
        private int _total;
        private DataSourse _dataSourse;
        public Sheet(DataSourse dataSourse)
        {
            _dataSourse = dataSourse;
        }
        public int GetTotal()
        {
            return _total;
        }
        public int CalcTotal(List<int> list)
        {
            var sum = 0;
            list.Select(x => sum += x);

            Console.WriteLine(sum);
            return sum;
        }

        public void Update()
        {
            _total = CalcTotal(_dataSourse.GetValues());
        }
    }
}
