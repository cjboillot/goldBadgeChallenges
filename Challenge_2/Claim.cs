using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class Claim
    {

        public int ClaimID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime DateAccident { get; set; }
        public DateTime DateClaim { get; set; }
        public bool IsValid { get; set; }

        public Claim(int claimID, string type, string description, int amount, DateTime dateAccident, DateTime dateClaim)
        {
             ClaimID = claimID;
             Type = type;
             Description = description;
             Amount = amount;
             DateAccident = dateAccident;
             DateClaim = dateClaim;
             IsValid = (dateClaim - dateAccident).Days <= 30;

        }

        public Claim()
        {
        }

        public override string ToString()
        {
            return $"{ClaimID}\t{Type}      {Description}      ${Amount}        {DateAccident}          {DateClaim}            {IsValid}\t";
             
        }

    }
}