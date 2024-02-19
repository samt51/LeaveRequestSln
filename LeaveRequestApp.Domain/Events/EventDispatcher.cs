namespace LeaveRequestApp.Domain.Events
{
    public class EventDispatcher
    {
        private static readonly EventDispatcher _instance = new EventDispatcher();
        private readonly List<object> _listeners;

        private EventDispatcher()
        {
            _listeners = new List<object>();
        }

        public static EventDispatcher Instance => _instance;

        public void AddListener<T>(IEventListener<T> listener) where T : IDomainEvent
        {
            _listeners.Add(listener);
        }

        public bool Dispatch<T>(T domainEvent) where T : IDomainEvent
        {
            foreach (var listener in _listeners)
            {
                if (listener is IEventListener<T> eventListener)
                {
                    eventListener.Handle(domainEvent);
                    
                    return true;
                }
            }
            return false;
        }
    }


}
