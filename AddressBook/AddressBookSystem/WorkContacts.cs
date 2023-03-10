using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class WorkContacts
    {
        private List<Person> contactList;
        private Dictionary<string, Person> contacts;
        public WorkContacts()
        {
            contactList = new List<Person>();
            contacts = new Dictionary<string, Person>();
        }

        public void AddContact()
        {
            Console.WriteLine("Enter your First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your city: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your State: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter your Zip: ");
            string zipCode = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your Email: ");
            string email = Console.ReadLine();
            Person addresses = new Person(firstName.ToLower(), lastName, address, city.ToLower(), state.ToLower(), zipCode, phoneNumber, email);
            contactList.Add(addresses);
            try
            {
                contacts.Add(firstName.ToLower(), addresses);
            }
            catch (Exception)
            {
                Console.WriteLine("Key already exists");
            }
        }
        public void GetContact()
        {
            foreach (KeyValuePair<string, Person> item in contacts)
                Console.WriteLine(item.Value);
        }

        public void EditContacts()
        {
            Console.WriteLine("Enter first name");
            string key = Console.ReadLine();
            if (contacts.ContainsKey(key))
            {
                Console.WriteLine("Enter your First Name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter your Address: ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter your city: ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter your State: ");
                string state = Console.ReadLine();
                Console.WriteLine("Enter your Zip: ");
                string zipCode = Console.ReadLine();
                Console.WriteLine("Enter your Phone Number: ");
                string phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter your Email: ");
                string email = Console.ReadLine();
                Person addresses = new Person(firstName.ToLower(), lastName, address, city.ToLower(), state.ToLower(), zipCode, phoneNumber, email);
                contactList.Add(addresses);
                contacts[key] = addresses;
            }
            else
                Console.WriteLine("First Name doesnt exist");
        }
        public void DeleteContacts()
        {
            Console.Write("Enter first name to Delete: ");
            string input = Console.ReadLine();
            if (contacts.ContainsKey(input.ToLower()))
                contacts.Remove(input.ToLower());
            else
                Console.WriteLine("first name doesnt exist");
        }

        public void SearchContact()
        {
            Console.Write("Enter city or state: ");
            string city = Console.ReadLine();
            Console.WriteLine($"Details of people who live in {city} - ");
            foreach (var item in contacts)
            {
                if (item.Value.city == city || item.Value.state == city)
                    Console.WriteLine(item.Value);
            }
        }



        public void SortedContactsByCityStateZip()
        {
            Console.WriteLine("Choose 1: To Search contacts by City");
            Console.WriteLine("Choose 2: To Search contacts by State");
            Console.WriteLine("Choose 3: To Search contacts by Zip");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        foreach (KeyValuePair<string, Person> item in contacts.OrderBy(x => x.Value.city))
                            Console.WriteLine(item.Value);
                        break;
                    case 2:
                        foreach (KeyValuePair<string, Person> item in contacts.OrderBy(x => x.Value.state))
                            Console.WriteLine(item.Value);
                        break;
                    case 3:
                        foreach (KeyValuePair<string, Person> item in contacts.OrderBy(x => x.Value.zipCode))
                            Console.WriteLine(item.Value);
                        break;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Please choose appropriate options from above");
            }

        }
        public void PersonCount(string cityOrState)
        {
            var list = contactList.FindAll(x => x.city == cityOrState || x.state == cityOrState);
            Console.WriteLine($"Number of person that live in {cityOrState} are : " + list.Count);
        }
    }
}
