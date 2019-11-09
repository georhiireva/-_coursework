using Coursework.helpers;
using System;
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

            obj.FirstName = BuildFirstName ();
            obj.LastName = BuildLastName ();
            obj.BirthDate = BuildBirthDate ();
            obj.Phones = BuildPhoneList ();
            obj.Emails = BuildEmailList ();
            obj.Addresses = BuildAddressList ();
            obj.Remark = BuildRemark ();
            return obj;
        }

        public static string BuildFirstName () {
            ConsoleUtil.PrintHeader ("Введите имя");
            return Console.ReadLine ();
        }

        public static string BuildLastName () {
            ConsoleUtil.PrintHeader ("Введите фамилию");
            return Console.ReadLine ();
        }

        public static DateTime BuildBirthDate () {
            ConsoleUtil.PrintHeader ("Введите дату рождения (yyyy-mm-dd");
            DateTime.TryParse (Console.ReadLine (), out DateTime birthDate);
            return birthDate;
        }

        public static  IList<Phone> BuildPhoneList () {
            var phoneList = new List<Phone> ();
            while (true) {
                if (!(Phone.BuildFromConsole (new Phone ()) is Phone phone))
                    break;
                phoneList.Add (phone);
            }
            return phoneList;
        }

        public static IList<Email> BuildEmailList () {
            var emailList = new List<Email> ();
            while (true) {
                if (!(Email.BuildFromConsole (new Email ()) is Email email))
                    break;
                emailList.Add (email);
            }
            return emailList;
        }

        public static IList<Address> BuildAddressList () {
            var addressList = new List<Address> ();
            while (true) {
                if (!(Address.BuildFromConsole (new Address ()) is Address address))
                    break;
                addressList.Add (address);
            }
            return addressList;
        }

        public static string BuildRemark () {
            ConsoleUtil.PrintHeader ("Введите комментарий");
            return Console.ReadLine ();
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
