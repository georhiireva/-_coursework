﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.entity {
    class Person {

        public Person () { }
        public Person (
            string firstName, string lastName, DateTime birthDate, 
            IEnumerable<Phone> phones, IEnumerable<Email> emails,
            IEnumerable<Address> addresses, string remark) {

            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Phones = phones;
            Emails = emails;
            Addresses = addresses;
            Remark = remark;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public IEnumerable<AbstractContactChannel> Phones { get; set; }
        public IEnumerable<AbstractContactChannel> Emails { get; set; }
        public IEnumerable<AbstractContactChannel> Addresses { get; set; }
        public string Remark { get; set; }

        public static Person BuildFromConsole (Person obj) {
            Console.WriteLine ();
            Console.WriteLine ("Введите имя");
            Console.WriteLine ();
            obj.FirstName = Console.ReadLine ();

            Console.WriteLine ();
            Console.WriteLine ("Введите фамилию");
            Console.WriteLine ();
            obj.LastName = Console.ReadLine ();

            Console.WriteLine ();
            Console.WriteLine ("Введите дату рождения (yyyy-mm-dd");
            Console.WriteLine ();
            DateTime birthDate;
            DateTime.TryParse (Console.ReadLine (), out birthDate);
            obj.BirthDate = birthDate;

            obj.Phones = new List<Phone> ();

            while (true) {
                var phone = Phone.BuildFromConsole (new Phone ());
                if (phone == null)
                    break;
                obj.Phones.ToList ().Add (phone);
            }

            obj.Emails = new List<Email> ();

            while (true) {
                var email = Phone.BuildFromConsole (new Email ());
                if (email == null)
                    break;
                obj.Emails.ToList ().Add (email);
            }

            obj.Addresses = new List<Address> ();

            while (true) {
                var address = Phone.BuildFromConsole (new Address ());
                if (address == null)
                    break;
                obj.Addresses.ToList ().Add (address);
            }

            Console.WriteLine ();
            Console.WriteLine ("Введите комментарий");
            Console.WriteLine ();
            obj.LastName = Console.ReadLine ();

            return obj;
        }

        public override string ToString () {
            StringBuilder phoneList = new StringBuilder ();
            foreach (var phone in Phones)
                phoneList.Append ($" {phone.Type} {phone.Value}\n");

            StringBuilder emailList = new StringBuilder ();
            foreach (var email in Emails)
                phoneList.Append ($" {email.Type} {email.Value}\n");

            StringBuilder addressList = new StringBuilder ();
            foreach (var address in Addresses)
                phoneList.Append ($" {address.Type} {address.Value}\n");

            return
                $"{FirstName} {LastName}\n{BirthDate}\n{phoneList}\n{emailList}\n{addressList}\n{Remark}";
        }

    }
}
