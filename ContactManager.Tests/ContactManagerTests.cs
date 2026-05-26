
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactManager;
using System.Linq;

namespace ContactManager.Tests
{
    [TestClass]
    public class ContactManagerTests
    {
        private global::ContactManager.ContactManager manager;

        [TestInitialize]
        public void Setup()
        {
            manager =
                new global::ContactManager.ContactManager();

            manager.Contacts.Clear();
        }

        [TestMethod]
        public void AddContact_AddsNewContact()
        {
            Contact contact = new Contact(
                "Ivan",
                "899999999");

            manager.AddContact(contact);

            Assert.AreEqual(
                1,
                manager.Contacts.Count);
        }

        [TestMethod]
        public void RemoveContact_RemovesContact()
        {
            Contact contact = new Contact(
                "Ivan",
                "899999999");

            manager.AddContact(contact);

            manager.RemoveContact(contact);

            Assert.AreEqual(
                0,
                manager.Contacts.Count);
        }

        [TestMethod]
        public void SearchContacts_FindsContactByName()
        {
            Contact contact = new Contact(
                "Ivan",
                "899999999");

            manager.AddContact(contact);

            var results =
                manager.SearchContacts("Ivan");

            Assert.AreEqual(
                1,
                results.Count);
        }

        [TestMethod]
        public void SearchContacts_FindsContactByPhone()
        {
            Contact contact = new Contact(
                "Ivan",
                "899999999");

            manager.AddContact(contact);

            var results =
                manager.SearchContacts("999");

            Assert.AreEqual(
                1,
                results.Count);
        }

        [TestMethod]
        public void SearchContacts_ReturnsEmptyList()
        {
            var results =
                manager.SearchContacts("AAAA");

            Assert.AreEqual(
                0,
                results.Count);
        }
    }
}