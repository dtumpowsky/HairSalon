using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistTests
    {
        public StylistTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=david_tumpowsky_hair_salon_tests;";
        }

        // [TestMethod]
        // public void StylistDB_is_Empty()
        // {
        //     int result = Stylist.GetAll().Count;
        //
        //     Assert.AreEqual(0, result);
        // }

        [TestMethod]
        public void Search_for_Stylist()
        {
            Stylist result = Stylist.Find(2);
            string finalResult = result.GetStylistName();

            Assert.AreEqual("stylistTwo", finalResult);
        }
    }
}
