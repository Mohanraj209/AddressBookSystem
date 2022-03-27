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
        public void AddContact(Contact contact)
        {
            addressList.Add(contact);
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
    }
}
