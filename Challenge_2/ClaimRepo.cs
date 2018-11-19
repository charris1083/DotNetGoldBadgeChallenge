using System;
using System.Collections.Generic;

namespace Challenge_2
{
    public class ClaimRepo
    {
        public Queue<Claim> number = new Queue<Claim>();
        bool _isValid;
        public void AddToQueue(Claim claim)
        {
            number.Enqueue(claim);
        }
        public void DeleteFromQueue()
        {
            number.Dequeue();
        }
        public Queue<Claim> SeeQueue()
        {
            return number;
        }

        public Claim PeekQueue()
        {
            return number.Peek();
        }

        public bool GetBool(Claim claim)
        {
            TimeSpan TimeBetweenDates = Convert.ToDateTime(claim.DateOfClaim) - Convert.ToDateTime(claim.DateOfIncident);

            bool IsValid;
            if(TimeBetweenDates.Days <= 30)
            {
                _isValid = true;
            }
            else
            {
                _isValid = false;
            }
            IsValid = _isValid;
            return IsValid;
        }
    }
}
