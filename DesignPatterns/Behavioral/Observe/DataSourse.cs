using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Observe
{
    public class DataSourse: Subject
    {
        private List<int> _values = new List<int>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values)
        {
            _values = values;
            NotifyObservers();
        }
    }
}
