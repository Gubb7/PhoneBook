using PhoneBook.Data;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace PhoneBook.Services
{
    public static class PhoneService
    {
        public static void Add()
        {
            Console.Write("Enter Fullname:");
            string fullname = Console.ReadLine();
            Console.Write("Enter Phone Number:");
            string phoneNumber = Console.ReadLine();
            if (!DataSource.Persons.Any(x => x.PhoneNumber == phoneNumber))
            {
                DataSource.Persons.Add(new Person { Name = fullname, PhoneNumber = phoneNumber });
            }
            else
            {
                Console.WriteLine("Invalid PhoneNumber");
            }
        }

        public static void GetByPhone()
        {
            Console.Write("Enter Phone Number:");
            string phoneNumber = Console.ReadLine();
            if (DataSource.Persons.Any(x => x.PhoneNumber == phoneNumber))
            {
                Person personByPhone = DataSource.Persons.First(x => x.PhoneNumber == phoneNumber);
                Console.WriteLine($"Fullname: {personByPhone.Name}\nPhoneNumber: {personByPhone.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("Invalid PhoneNumber");
            }
        }

        public static void GetByName()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            if (DataSource.Persons.Any(x => x.Name == name))
            {
                List<Person> personsByName = new List<Person>(DataSource.Persons.Where(x => x.Name == name));
                foreach (Person person in personsByName)
                {
                    Console.WriteLine($"Fullname: {person.Name}\nPhoneNumber: {person.PhoneNumber}");
                }
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }

        public static void GetAll()
        {
            foreach(Person person in DataSource.Persons)
            {
                Console.WriteLine($"Fullname: {person.Name}  PhoneNumber: {person.PhoneNumber}");
            }
        }

        public static void DeleteByPhone()
        {
            Console.Write("Enter Phone Number:");
            string phoneNumber = Console.ReadLine();
            if (DataSource.Persons.Any(x => x.PhoneNumber == phoneNumber))
            {
                DataSource.Persons.First(x => x.PhoneNumber == phoneNumber);
            }
            else
            {
                Console.WriteLine("Inavalid PhoneNumber");
            }
        }
    }
}
