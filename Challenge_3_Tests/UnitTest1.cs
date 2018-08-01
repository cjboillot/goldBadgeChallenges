using System;
using System.Collections.Generic;
using Challenge_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_3_Tests
{
    [TestClass]
    public class UnitTest1
    {
        EventRepository Repo = new EventRepository();

        [TestMethod]
        public void AddEventTypesToList()
        {
            //arrange
            //add repo, make items, add to repo
            DateTime t1 = new DateTime(2018, 06, 4);
            EventRepository Repo = new EventRepository();
            Event type = new Event(EventType.golf, 2, t1, 50);

            Repo.AddEventTypesToList(type);

            //act
            //expected, actual

            int Expected = 1;
            int Actual = Repo.Count();

            //assert
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Claim_GetList_ShouldGetList()
        {
            //arrange
            List<Event> list = new List<Event>();
            DateTime t1 = new DateTime(2018, 06, 4);
            EventRepository Repo = new EventRepository();
            Event type = new Event(EventType.golf, 2, t1, 50);

            Repo.AddEventTypesToList(type);
            list = Repo.getEventsList();

            //act
            int Expected = 1;
            int Actual = list.Count;
            //assert
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void AddAllOutings()
        {
            //arrange

            List<Event> list = new List<Event>();
            DateTime t1 = new DateTime(2018, 06, 4);
            DateTime t2 = new DateTime(2018, 06, 5);
            EventRepository Repo = new EventRepository();
            Event type = new Event(EventType.golf, 2, t1, 50);
            Event type2 = new Event(EventType.golf, 2, t1, 50);

            Repo.AddEventTypesToList(type);
            Repo.AddEventTypesToList(type2);
            Repo.AddAllOutings();

            //act
            int Expected = 200;
            int Actual = Repo.AddAllOutings();

            //assert
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TypeSum()
        {

            List<Event> list = new List<Event>();
            DateTime t1 = new DateTime(2018, 06, 4);
            DateTime t2 = new DateTime(2018, 06, 5);
            EventRepository Repo = new EventRepository();
            Event type1 = new Event(EventType.golf, 2, t1, 50);
            Event type2 = new Event(EventType.golf, 2, t1, 50);
            Event type3 = new Event(EventType.bowling, 2, t1, 50);

            Repo.AddEventTypesToList(type1);
            Repo.AddEventTypesToList(type2);
            Repo.AddEventTypesToList(type3);
            Repo.TypeSum(EventType.golf);

            //act
            int Expected = 200;
            int Actual = Repo.TypeSum(EventType.golf);

            //assert
            Assert.AreEqual(Expected, Actual);

        }

        

    }

}