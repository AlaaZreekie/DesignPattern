using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Iterator.good
{
    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        T Current();
    }
}
