using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class EventRepository
    {
        //-- Fields
        public List<Event> _EventTypes = new List<Event>();
        List<Event> _eventList = new List<Event>();

        //-- Methods
        public void AddEventTypesToList(Event eventType)
        {
            _eventList.Add(eventType);
        }

        public int Count()
        {
            return _eventList.Count;
        }

        public void PrintList(List<Event> list)
        {
            foreach (Event item in list)
            {
                Console.WriteLine(item);
            }
        }

        public List<Event> getEventsList()
        {
            return _eventList;
        }

        public int AddAllOutings()
        {
            int sum = 0;
            foreach (Event sumation in _eventList)
            {
                sum += sumation.costTotal;
            }
            return sum;
        }

        public int TypeSum(EventType type)
        {
            int sum = 0;

            foreach (Event sumation in _eventList)
            {
                if (sumation.eventType == type)
                {
                    sum += sumation.costTotal;
                }
            }
            return sum;
        }
    }
}
