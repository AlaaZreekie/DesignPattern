using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SOLID.DependencyInversion
{
    public class Car
    {
        private IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void StartCar()
        {
            _engine.Start();
            Console.WriteLine("Car Started");
        }
    }
}
/*
IEnumerable<T> is the base interface that the following extend or implement. It doesn't allow for direct access and is readonly. So use this only if you intend to iterate over the collection.

ICollection<T> extendsIEnumerable<T> but in addition allows for adding, removing, testing whether an element is present in the collection and getting the total number of elements. It doesn't allow for directly accessing an element by index. That would be an O(n) operation as you need to start iterating over it until you find the corresponding element.

IList<T> extends ICollection<T> (and thus it inherits all its properties) but in addition allows for directly accessing elements by index. It's an O(1) operation.

List<T> is just a concrete implementation of the IList<T> interface.
*/