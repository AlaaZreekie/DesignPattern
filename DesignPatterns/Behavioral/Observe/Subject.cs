﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPatterns.Behavioral.Observe
{
    public class Subject
    {
        private List<IObserver> _observers = new List<IObserver>(); 

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.Select(o =>
                {
                    o.Update();
                    return o;
                });
        }
    }
}
