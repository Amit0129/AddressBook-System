﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class WorkContacts
    {
        private List<AddressBook> contactList;
        private Dictionary<string, AddressBook> contacts;
        public WorkContacts()
        {
            contactList = new List<AddressBook>();
            contacts = new Dictionary<string, AddressBook>();
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
            AddressBook addresses = new AddressBook(firstName.ToLower(), lastName, address, city, state, zipCode, phoneNumber, email);
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
            foreach (KeyValuePair<string, AddressBook> item in contacts)
            {
                Console.WriteLine(item.Value);
            }
        }

        public void EditContacts(string key)
        {
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
                AddressBook addresses = new AddressBook(firstName.ToLower(), lastName, address, city, state, zipCode, phoneNumber, email);
                contactList.Add(addresses);
                contacts[key] = addresses;
            }
            else
            {
                Console.WriteLine("First Name doesnt exist");
            }
        }
        public void DeleteContacts()
        {
            Console.WriteLine("Enter first name to Delete");
            string input = Console.ReadLine();
            if (contacts.ContainsKey(input.ToLower()))
            {
                contacts.Remove(input.ToLower());
            }
            else
            {
                Console.WriteLine("first name doesnt exist");
            }
        }

        public void SearchByCity(string city)
        {
            var list = contactList.FindAll(x => x.city == city);
            Console.WriteLine($"Details of people who live in {city} - ");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
        public void SearchByState(string state)
        {
            var list = contactList.FindAll(x => x.state == state);
            Console.WriteLine($"Details of people who live in {state} - ");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

    }
}