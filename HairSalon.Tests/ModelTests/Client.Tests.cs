using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientTests
    {

        public ClientTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=david_tumpowsky_hair_salon_tests;";
        }

        // [TestMethod]
        // public void ClientDB_is_Empty()
        // {
        //     int result = Client.GetAll().Count;
        //
        //     Assert.AreEqual(0, result);
        // }

        [TestMethod]
        public void Search_for_Client()
        {
            Client result = Client.Find(3);
            string finalResult = result.GetClientName();

            Assert.AreEqual("clientOne", finalResult);
        }

        [TestMethod]
        public void Search_for_Client_via_StylistID()
        {
            Client result = Client.Find(3);
            int finalResult = result.GetStylistId();

            Assert.AreEqual(2, finalResult);
        }
    }
}
