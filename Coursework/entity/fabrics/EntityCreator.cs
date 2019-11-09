using Coursework.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.entity.fabrics {
    class EntityCreator {
        public static Person CreatePerson () {
            Person person = new Person {
                FirstName = BuildFirstName (),
                LastName = BuildLastName (),
                BirthDate = BuildBirthDate (),
                Phones = BuildPhoneList (),
                Emails = BuildEmailList (),
                Addresses = BuildAddressList (),
                Remark = BuildRemark ()
            };
            return person;
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

        public static IList<Phone> BuildPhoneList () {
            var phoneList = new List<Phone> ();
            while (true) {
                var phone = CreatePhone ();
                if (phone == null)
                    break;
                phoneList.Add (phone);
            }
            return phoneList;
        }

        public static IList<Email> BuildEmailList () {
            var emailList = new List<Email> ();
            while (true) {
                var email = CreateEmail ();
                if (email == null)
                    break;
                emailList.Add (email);
            }
            return emailList;
        }

        public static IList<Address> BuildAddressList () {
            var addressList = new List<Address> ();
            while (true) {
                var address = CreateAddress ();
                if (address == null)
                    break;
                addressList.Add (address);
            }
            return addressList;
        }

        public static string BuildRemark () {
            ConsoleUtil.PrintHeader ("Введите комментарий");
            return Console.ReadLine ();
        }

        public static Phone CreatePhone () {
            ConsoleUtil.PrintHeader ($"Добавление нового телефона");
            ConsoleUtil.PrintHeader ("Для выхода введите -1 в любое время");
            Phone phone = new Phone {
                Type = ChannelType,
                Value = ChannelValue
            };
            if (phone.Type == null || phone.Value == null)
                return null;
            return phone;
        }

        public static Email CreateEmail () {
            ConsoleUtil.PrintHeader ($"Добавление новой электронной почты");
            ConsoleUtil.PrintHeader ("Для выхода введите -1 в любое время");
            Email email = new Email () {
                Type = ChannelType,
                Value = ChannelValue
            };
            if (email.Type == null || email.Value == null)
                return null;
            return email;
        }

        public static Address CreateAddress () {
            ConsoleUtil.PrintHeader ($"Добавление нового почтового адреса");
            ConsoleUtil.PrintHeader ("Для выхода введите -1 в любое время");
            Address address = new Address () {
                Type = ChannelType,
                Value = ChannelValue
            };
            if (address.Type == null || address.Value == null)
                return null;
            return address;
        }

        private static string ChannelType {
            get {
                var type = ConsoleUtil.ReadFromConsole ("Введите тип");
                if (type == "-1")
                    return null;
                return type;
            }
        }

        private static string ChannelValue {
            get {
                var value = ConsoleUtil.ReadFromConsole ("Введите значение");
                if (value == "-1")
                    return null;
                return value;
            }
        }
        public static AbstractContactChannel BuildFromConsole (AbstractContactChannel obj) {
            ConsoleUtil.PrintHeader ($"Добавление нового {obj.RusName}");
            ConsoleUtil.PrintHeader ("Для выхода введите -1 в любое время");

            var type = ConsoleUtil.ReadFromConsole ("Введите тип");
            if (type == "-1")
                return null;
            obj.Type = type;

            var value = ConsoleUtil.ReadFromConsole ("Введите значение");
            if (value == "-1")
                return null;
            obj.Value = value;

            return obj;
        }
    }
}

