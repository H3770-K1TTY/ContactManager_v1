using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Windows.Forms;

namespace ContactManager
{
    public partial class Form1 : Form
    {
        private ContactManager manager;

        public Form1()
        {
            InitializeComponent();

            manager = new ContactManager();

            UpdateList();
        }

        private void UpdateList()
        {
            contactsListBox.Items.Clear();

            foreach (var contact in manager.Contacts)
            {
                contactsListBox.Items.Add(contact);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            Contact contact = new Contact(
                nameTextBox.Text,
                phoneTextBox.Text);

            manager.AddContact(contact);

            UpdateList();

            nameTextBox.Clear();
            phoneTextBox.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (contactsListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите контакт");
                return;
            }

            Contact contact =
                manager.Contacts[contactsListBox.SelectedIndex];

            manager.RemoveContact(contact);

            UpdateList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            contactsListBox.Items.Clear();

            var results =
                manager.SearchContacts(searchTextBox.Text);

            foreach (var contact in results)
            {
                contactsListBox.Items.Add(contact);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}