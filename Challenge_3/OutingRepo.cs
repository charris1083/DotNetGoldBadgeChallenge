using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class OutingRepo
    {
        List<Outing> _outingList = new List<Outing>();

        public void AddOutingsToList(Outing outing)
        {
            _outingList.Add(outing);
        }

        public List<Outing> ViewList()
        {
            return _outingList;
        }

        public decimal AddCostOfOutings()
        {
            decimal total = 0;
            foreach (Outing outing in _outingList)
            {
                total += outing.CostOfEvent;
            }
            return total;
        }

        public decimal AddCostByEvent(string type)
        {
            decimal typeTotal = 0;
            foreach (Outing totalEvent in _outingList)
            {
                if (type == totalEvent.EventType)
                {
                    typeTotal += totalEvent.CostOfEvent;
                }
            }
            return typeTotal;
        }
    }
}
