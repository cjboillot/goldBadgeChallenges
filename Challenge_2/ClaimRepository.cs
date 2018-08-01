using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ClaimRepository
    {
        Queue<Claim> _claimList = new Queue<Claim>();

        public void AddClaimToList(Claim item)
        {
            _claimList.Enqueue(item);
        }

        public Queue<Claim> GetClaimsList()
        {
            return _claimList;
        }

        public Claim SeeCurrentClaim()
        {
            return _claimList.Peek();
        }

        public void CurrentClaimFinished()
        {
            _claimList.Dequeue();
        }

        public void PrintList(Queue<Claim> list)
        {
            foreach (Claim item in list)
            {
                Console.WriteLine(item);
            }
        }
        public int Count()
        {
            return _claimList.Count;
        }
    }
}

    