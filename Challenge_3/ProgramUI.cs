using System;
using System.Collections.Generic;

namespace Challenge_3
{
    class ProgramUI
    {
        OutingRepo outingRepo = new OutingRepo();
        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose and option:" +
                   "\n1. Add an outing." +
                   "\n2. View List of outings." +
                   "\n3. Total cost of outings." +
                   "\n4. Cost of outings by event." +
                   "\n5. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddOuting();
                        break;
                    case 2:
                        VeiwList();
                        break;
                    case 3:
                        Console.WriteLine($"Total cost of outings is {outingRepo.AddCostOfOutings()}");
                        Console.ReadLine();
                        break;
                    case 4:
                        EventCost();
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Key");
                        break;
                }
            }
        }

        private void EventCost()
        {
            List<Outing> outingList = outingRepo.ViewList();

            Console.WriteLine("Would you like to veiw event cost? y/n");
            string outing = Console.ReadLine();

            foreach (Outing _event in outingList)
            {
                bool y = true;
                if (y)
                {
                    Console.WriteLine($"The total cost for this event is: {_event.CostOfEvent}");
                }
            }

            Console.ReadLine();


        }

        private void VeiwList()
        {
            List<Outing> outingList = outingRepo.ViewList();
            foreach (Outing outing in outingList)
            {
                Console.WriteLine($"List of outings:\n {outing.EventType}, {outing.DateOfOuting}, {outing.NumberOfPeople}, {outing.CostPerPerson}, {outing.CostOfEvent}.");
            }
            Console.ReadLine();
        }

        private void AddOuting()
        {
            Outing newOuting = new Outing();
            Console.WriteLine("Enter event type: ");
            newOuting.EventType = Console.ReadLine();

            Console.WriteLine("Enter date of outing: ");
            newOuting.DateOfOuting = Console.ReadLine();

            Console.WriteLine("Enter total number of people attending: ");
            newOuting.NumberOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter cost per person: ");
            newOuting.CostPerPerson = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter cost of event: ");
            newOuting.CostOfEvent = decimal.Parse(Console.ReadLine());

            outingRepo.AddOutingsToList(newOuting);
        }
    }
}
