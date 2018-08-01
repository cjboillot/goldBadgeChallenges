using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class EventRepository
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
            return _EventTypes.Count;
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

        public string TypeSum()
        {
            string sumt = " ";

            int golf = 0;
            int bowling = 0;
            int amusementPark = 0;
            int concert = 0;

            foreach (Event sumation in _eventList)
            {
                if ()
            }
            return sumt;
        }

    }
}

