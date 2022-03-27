using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        List<Contact> addressList = new List<Contact>();
        Dictionary<string, List<Contact>> dictionary = new Dictionary<string, List<Contact>>();
        public void AddContact(Contact contact)
        {
            addressList.Add(contact);
            dictionary.Add(contact.FirstName, addressList);
        }
        public void EditContact(string name)
        {
            foreach (var contact in addressList)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    Console.WriteLine("Choose the field you want to edit : \n 1. First name \n 2. Last name \n 3. Address \n 4. City \n 5. State \n 6. Zip code \n 7. Phone Number \n 8. Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter you want to edit");
                            string first = Console.ReadLine();
                            contact.FirstName = first;
                            break;
                        case 2:
                            Console.WriteLine("Enter you want to edit");
                            string last = Console.ReadLine();
                            contact.LastName = last;
                            break;
                        case 3:
                            Console.WriteLine("Enter you want to edit");
                            string address = Console.ReadLine();
                            contact.Address = address;
                            break;
                        case 4:
                            Console.WriteLine("Enter you want to edit");
                            string city = Console.ReadLine();
                            contact.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter you want to edit");
                            string state = Console.ReadLine();
                            contact.State = state;
                            break;
                        case 6:
                            Console.WriteLine("Enter you want to edit");
                            string zip = Console.ReadLine();
                            contact.Zip = zip;
                            break;
                        case 7:
                            Console.WriteLine("Enter you want to edit");
                            string phone = Console.ReadLine();
                            contact.PhoneNumber = phone;
                            break;
                        case 8:
                            Console.WriteLine("Enter you want to edit");
                            string email = Console.ReadLine();
                            contact.Email = email;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void DeleteContact(string name)
        {
            Contact delete = new Contact();
            foreach (var contact in addressList)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    delete = contact;
                }
            }
            addressList.Remove(delete);
            Console.WriteLine(name + " contact is deleted from the Address Book");
        }
        public void Display()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Here are the contacts in your Address Book : ");
            foreach (var contact in addressList)
            {
                Console.WriteLine(contact.FirstName + "\t" + contact.LastName + "\t" + contact.City + "\t" + contact.PhoneNumber);
            }
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }
        public void AddUniqueContact()
        {
            foreach (var contact in addressList)
            {
                string uniqueName = Console.ReadLine();
                dictionary.Add(uniqueName, addressList);
            }
        }
        public void DisplayUniqueContacts()
        {
            Console.WriteLine("Enter name of dictionary to display that contact details");
            string name = Console.ReadLine().ToLower();
            foreach (var contacts in dictionary)
            {
                if (contacts.Key == name)
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine("The Contact details of " + data.FirstName + "are : \n" + data.FirstName + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                    }
                }
            }
            Console.WriteLine("Oops Unique Contacts does not exist !!! Please create a Unique contact list");
            return;
        }
        public void CheckDuplicateEntry()
        {
            Console.WriteLine("Enter the name to check : ");
            string check = Console.ReadLine();
            var person = addressList.Find(e => e.FirstName.Equals(check));
            if (person != null)
            {
                Console.WriteLine("This Contact already exists with same First Name : " + check);
            }
            else
            {
                Console.WriteLine("You Can Proceed");
            }
        }

        public void CityList()
        {
            Console.WriteLine("Enter the City name to find persons : ");
            string city = Console.ReadLine();
            List<Contact> cityList = addressList.FindAll(e => e.City == city);
            foreach (var data in cityList)
            {
                Console.WriteLine("Found person {0} {1} in the Address Book , residing in the City {2}", data.FirstName, data.LastName, data.City);
            }
        }
        public void StateList()
        {
            Console.WriteLine("Enter the State name to find persons : ");
            string state = Console.ReadLine();
            List<Contact> stateList = addressList.FindAll(e => e.State == state);
            foreach (var data in stateList)
            {
                Console.WriteLine("Found person {0} {1} in the Address Book , residing in the State {2}", data.FirstName, data.LastName, data.State);
            }
        }
    }
}
