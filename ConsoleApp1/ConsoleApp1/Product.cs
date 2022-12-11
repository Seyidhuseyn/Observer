using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        public void UnAttach(Observer observer)
        {
            _observers.Remove(observer);
        }
        private void Notify()
        {
            _observers.ForEach(o => { o.Update(); });
        }
        public void ChangeStock()
        {
            this.Notify();
        }
    }
}
