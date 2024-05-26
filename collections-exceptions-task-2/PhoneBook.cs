using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_exceptions_task_2
{
    internal class PhoneBook
    {
        private Dictionary<string, string> contacts;

        public Dictionary<string, string> Contacts { get; }


        public PhoneBook()
        {
            Contacts = new Dictionary<string, string>();
        }

        public void AddContact(string name, string phoneNumber)
        {
            if (!Contacts.ContainsKey(name))
            {
                Contacts[name] = phoneNumber;
                Console.WriteLine($"Name ({name}) added with this number ({phoneNumber})");
            }
            else
                Console.WriteLine("This contact already exists");
        }

        public void RemoveContact(string name)
        {
            if (Contacts.ContainsKey(name))
                Contacts.Remove(name);

            else
                Console.WriteLine("Contact not found");
        }

        public void GetAllContacts()
        {
            foreach (var contact in Contacts)
                Console.WriteLine($"Name: {contact.Key} Number: {contact.Value}");
        }

        public void FindContactByName(string name)
        {
            if(Contacts.ContainsKey(name))
                Console.WriteLine($"Name: {name} Number: {Contacts[name]}");
            else
                Console.WriteLine("Contact not found");
        }
    }
}
