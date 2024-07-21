using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Data
{
    public static class DataSource
    {
        public static List<Person> Persons { get; set; } = new List<Person>() 
        {
            new()
            {
                Name = "Kostya STO",
                PhoneNumber = "37500493"
            },
            new()
            {
                Name = "John",
                PhoneNumber = "640603740"
            },
            new ()
            {
                Name = "Valera",
                PhoneNumber = "38750377"
            },
            new ()
            {
                Name = "Valera MTS",
                PhoneNumber = "97405172"
            },
            new ()
            {
                Name = "Nazariy",
                PhoneNumber = "89712381"
            },
            new ()
            {
                Name = "Sashen'ka",
                PhoneNumber = "75648260"
            },
            new ()
            {
                Name = "Stariy",
                PhoneNumber = "12438581"           
            },
            new ()
            {
                Name = "Artem Tandyr",
                PhoneNumber = "66619354"
            },
            new ()
            {
                Name = "YA",
                PhoneNumber = "38503701"
            },
            new ()
            {
                Name = "John",
                PhoneNumber = "890669701"
            }
        };
    } 
}
