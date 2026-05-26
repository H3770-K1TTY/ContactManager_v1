using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactManager;

namespace ContactManager.Tests
{
    [TestClass]
    public class BoundaryTests
    {
        [TestMethod]
        public void EmptyName_IsAllowed()
        {
            Contact contact = new Contact(
                "",
                "899999999");

            Assert.AreEqual(
                "",
                contact.Name);
        }

        [TestMethod]
        public void EmptyPhone_IsAllowed()
        {
            Contact contact = new Contact(
                "Ivan",
                "");

            Assert.AreEqual(
                "",
                contact.PhoneNumber);
        }

        [TestMethod]
        public void LongPhoneNumber_IsStoredCorrectly()
        {
            Contact contact = new Contact(
                "Ivan",
                "12345678901234567890");

            Assert.AreEqual(
                "12345678901234567890",
                contact.PhoneNumber);
        }
    }
}