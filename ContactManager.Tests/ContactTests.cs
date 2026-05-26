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
    public class ContactTests
    {
        [TestMethod]
        public void Constructor_SetsNameCorrectly()
        {
            Contact contact = new Contact(
                "Ivan",
                "899999999");

            Assert.AreEqual(
                "Ivan",
                contact.Name);
        }

        [TestMethod]
        public void Constructor_SetsPhoneCorrectly()
        {
            Contact contact = new Contact(
                "Ivan",
                "899999999");

            Assert.AreEqual(
                "899999999",
                contact.PhoneNumber);
        }

        [TestMethod]
        public void ToString_ReturnsCorrectFormat()
        {
            Contact contact = new Contact(
                "Ivan",
                "899999999");

            string result = contact.ToString();

            Assert.AreEqual(
                "Ivan - 899999999",
                result);
        }
    }
}