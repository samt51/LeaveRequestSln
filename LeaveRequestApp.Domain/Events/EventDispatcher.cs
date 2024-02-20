using System.Diagnostics.Tracing;

namespace LeaveRequestApp.Domain.Events
{
    public class EventDispatcher
    {
        private readonly List<IEventListener> _listeners;

        public EventDispatcher()
        {
            _listeners = new List<IEventListener>();
        }

        public void AddListener(IEventListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveListener(IEventListener listener)
        {
            _listeners.Remove(listener);
        }

        public bool Dispatch(IDomainEvent domainEvent)
        {
            foreach (var listener in _listeners)
            {
                if (listener.CanHandle(domainEvent))
                {
                    listener.Handle(domainEvent);
                    return true;
                }
                else
                {
                    return false;   
                }
            }
            return false;
        }
    }



}
