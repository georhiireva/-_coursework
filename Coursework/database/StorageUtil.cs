using Coursework.entity;
using Coursework.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.database {
    class StorageUtil {

        public static Person SearchContactByConsole () {
            var firstName = ConsoleUtil.ReadFromConsole ("Введите имя контакта");
            var lastName = ConsoleUtil.ReadFromConsole ("Введите фамилию контакта");
            return FindContact (firstName, lastName);
        }
        private static Person FindContact (string firstName, string lastName) =>
            Storage.Instance.Contacts
                .Where (contact => contact.FirstName == firstName && contact.LastName == lastName)
                .FirstOrDefault ();
    }
}
