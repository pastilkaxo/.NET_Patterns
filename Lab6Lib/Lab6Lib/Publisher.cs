using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Lib
{
    public class Publisher
    {

        private List<ISubscriber> _observers = new List<ISubscriber>();
        private string EventName { get; set; }
        public Publisher(string eventname)
        {
            this.EventName = eventname;
        }

        public void subscribe(ISubscriber subscriber)
        {
            this._observers.Add(subscriber);
        }
        public void unsubscribe(ISubscriber subscriber)
        {
            this._observers.Remove(subscriber);
        }

        public int nonify()
        {
            foreach(ISubscriber subscriber in _observers)
            {
                subscriber.update(EventName);
            }
            return _observers.Count;
        }
    }
}
