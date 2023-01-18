using System.Collections;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workContacts = new WorkContacts();
            var familyContacts = new FamilyContacts();

            int option = 0, input = 0;
            do
            {
                try
                {
                    Console.WriteLine("Choose 1: Work contacts");
                    Console.WriteLine("Choose 2: Family contacts");
                    Console.WriteLine("Choose 0: Exit");
                    input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            do
                            {
                                Console.WriteLine("Choose 1: To Add a Contact");
                                Console.WriteLine("Choose 2: To get Contacts");
                                Console.WriteLine("Choose 3: To Edit a contact");
                                Console.WriteLine("Choose 4: To Delete a Contact");
                                Console.WriteLine("Choose 5: To Search Contact by city or state");
                                Console.WriteLine("Choose 6: To Get Sorted Contacts by city, state or zip");
                                Console.WriteLine("Choose 7: Search number of Contact by city or state");
                                Console.WriteLine("Choose 0: To Exit");
                                try
                                {
                                    option = int.Parse(Console.ReadLine());
                                    switch (option)
                                    {
                                        case 1:
                                            workContacts.AddContact();
                                            continue;
                                        case 2:
                                            workContacts.GetContact();
                                            continue;
                                        case 3:

                                            workContacts.EditContacts();
                                            break;
                                        case 4:
                                            workContacts.DeleteContacts();
                                            break;
                                        case 5:
                                            workContacts.SearchContact();
                                            break;
                                        case 6:
                                            workContacts.SortedContactsByCityStateZip();
                                            break;
                                        case 7:
                                            Console.WriteLine("Enter city or state");
                                            string city = Console.ReadLine();
                                            workContacts.PersonCount(city);
                                            break;
                                        default:
                                            Console.WriteLine("Choose valid Option");
                                            break;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Please choose an option");
                                }
                            } while (option != 0);
                            break;
                        case 2:
                            do
                            {
                                Console.WriteLine("Choose 1: To Add a Contact");
                                Console.WriteLine("Choose 2: To get Contacts");
                                Console.WriteLine("Choose 3: To Edit a contact");
                                Console.WriteLine("Choose 4: To Delete a Contact");
                                Console.WriteLine("Choose 5: To Search Contact by city or state");
                                Console.WriteLine("Choose 6: To Get Sorted Contacts by city, state or zip");
                                Console.WriteLine("Choose 7: Search number of Contact by city or state");
                                Console.WriteLine("Choose 0: To Exit");
                                try
                                {
                                    option = int.Parse(Console.ReadLine());
                                    switch (option)
                                    {
                                        case 1:
                                            familyContacts.AddContact();
                                            continue;
                                        case 2:
                                            familyContacts.GetContact();
                                            continue;
                                        case 3:
                                            familyContacts.EditContacts();
                                            break;
                                        case 4:
                                            familyContacts.DeleteContacts();
                                            break;
                                        case 5:
                                            familyContacts.SearchContact();
                                            break;
                                        case 6:
                                            familyContacts.SortedContactsByCityStateZip();
                                            break;
                                        case 7:
                                            Console.WriteLine("Enter city or state");
                                            string city = Console.ReadLine();
                                            familyContacts.PersonCount(city);
                                            break;
                                        default:
                                            Console.WriteLine("Choose valid Option");
                                            break;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Please choose an option");
                                }
                            } while (option != 0);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please choose valid Options");
                }
            } while (input != 0);
        }
    }
}