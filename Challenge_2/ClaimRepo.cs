using System.Collections.Generic;

namespace Challenge_2
{
    class ClaimRepo
    {

        public Queue<Claim> number = new Queue<Claim>();
        public Queue<Claim> Queue
        {
            get { return number; }
            set { number = value; }

        }
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
    }
}
