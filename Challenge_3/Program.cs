using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            EventRepository eventRepo = new EventRepository();
            List<Event> Events = eventRepo.getEventsList();

            DateTime e1 = new DateTime(2018, 06, 1);
            DateTime e2 = new DateTime(2018, 06, 2);
            DateTime e3 = new DateTime(2018, 06, 3);
            DateTime e4 = new DateTime(2018, 06, 4);

            Event Golf = new Event(EventType.golf, 2, e1, 5);
            Event Bowling = new Event(EventType.bowling, 3, e2, 6);
            Event AmusementPark = new Event(EventType.amusementPark, 4, e3, 7);
            Event Concert = new Event(EventType.concert, 5, e4, 8);


            eventRepo.AddEventTypesToList(Golf);
            eventRepo.AddEventTypesToList(Bowling);
            eventRepo.AddEventTypesToList(AmusementPark);
            eventRepo.AddEventTypesToList(Concert);

            Console.WriteLine("Employee Outings and Costs");

            Console.WriteLine("\n");
            eventRepo.PrintList(eventRepo.getEventsList());
            Console.WriteLine("\n");

            while (true)
            {
                Console.WriteLine("Would you like to 1. Display Outings, 2. Add a NEW Outing, 3. Total Cost of ALL Outings , or 4. Total cost of Outings by type?");
                string choice = Console.ReadLine();


                if (choice == "1")
                {
                    
                        eventRepo.PrintList(eventRepo.getEventsList());
                        Console.WriteLine("\n");

                }

                if (choice == "2")
                {
                    while (true)
                    {

                       Console.WriteLine("What is the type of Event?");
                       
                      

                        Console.WriteLine("How many people will go to the Event?");
                        int eventNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("What is the date of the Event?");
                        DateTime dateEvent = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("How much will it cost per person?");
                        int costPer = int.Parse(Console.ReadLine());

                        





                        Event userEvent = new Event(eventType, eventNumber, dateEvent, costPer);
                        eventRepo.AddEventTypesToList(userEvent);



                        Console.WriteLine("Do you want to add another Event?");
                        string theAnswer = Console.ReadLine();

                        if (theAnswer == "y")
                        {
                            continue;
                        }

                        else if (theAnswer == "n")
                        {
                            eventRepo.PrintList(eventRepo.getEventsList());
                            Console.ReadLine();
                            continue;
                        }
                    }
                }

                else if (choice == "3")
                {


                    Console.WriteLine("The total sum of all outings is $" + eventRepo.AddAllOutings());
                    Console.ReadLine();
                }


                else if (choice == "4")
                {
                    Console.WriteLine();

                    Console.ReadLine();
                }
            }
        }
    }
}

