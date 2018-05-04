using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientTests : IDisposable
    {
        public void Dispose()
        {
            Client.DeleteAll();
        }
        public ClientTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=david_tumpowsky_hair_salon_tests;";
        }

        [TestMethod]
        public void ClientDB_is_Empty()
        {
            int result = Client.GetAll().Count;

            Assert.AreEqual(0, result);
        }
    }
}
