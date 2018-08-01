using System;
using System.Collections.Generic;
using Challenge_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        ClaimRepository Repo = new ClaimRepository();


        // Add Item
        [TestMethod]
        public void Claim_AddItem_CountShouldIncrease()
        {
            DateTime t1a = new DateTime(2018, 06, 1);
            DateTime t1b = new DateTime(2018, 06, 20);
            
            Claim item = new Claim(5, "Car", "Accident-Ice", 450, (t1a), (t1b));

            Repo.AddClaimToList(item);

            int Expected = 1;
            int Actual = Repo.Count();

            Assert.AreEqual(Expected, Actual);
        }


        //Get List
        [TestMethod]
        public void Claim_GetList_ShouldPrintList()
        {
            DateTime t2a = new DateTime(2018, 06, 1);
            DateTime t2b = new DateTime(2018, 06, 20);

            Queue<Claim> list = new Queue<Claim>();
            Claim item = new Claim(5, "Car", "Accident-Ice", 450, (t2a), (t2b));

            ClaimRepository Repo = new ClaimRepository();
            Repo.AddClaimToList(item);
            list = Repo.GetClaimsList();

            int Expected = 1;
            int Actual = list.Count;

            Assert.AreEqual(Expected, Actual);
        }

        //Dequeue
        [TestMethod]
        public void Claim_AddItem_CountShouldDecrease()
        {
            DateTime t3a = new DateTime(2018, 06, 1);
            DateTime t3b = new DateTime(2018, 06, 20);

            Claim item = new Claim(5, "Car", "Accident-Ice", 450, (t3a), (t3b));

            Repo.AddClaimToList(item);
            Repo.CurrentClaimFinished();

            int Expected = 0;
            int Actual = Repo.Count();

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Claim_SeeCurrent_ShouldPrintCurrent()
        {
            DateTime t2a = new DateTime(2018, 06, 1);
            DateTime t2b = new DateTime(2018, 06, 20);

            Queue<Claim> list = new Queue<Claim>();
            Claim item = new Claim(5, "Car", "Accident-Ice", 450, (t2a), (t2b));

            ClaimRepository Repo = new ClaimRepository();
            Repo.AddClaimToList(item);
            list = Repo.GetClaimsList();

            int Expected = 1;
            int Actual = list.Count;

            Assert.AreEqual(Expected, Actual);
        }
    }
   
}
