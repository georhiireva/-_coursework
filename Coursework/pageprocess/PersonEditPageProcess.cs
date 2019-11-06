using Coursework.commands;
using Coursework.database;
using Coursework.entity;
using Coursework.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.pageprocess {
    class PersonEditPageProcess : AbstractPageProcess {

        public override void Run () {
            ConsoleUtil.PrintHeader(Name);

            var contact = SearchContactByConsole();
            
            if (contact == null) {
                ConsoleUtil.PrintHeader("Контакт не найден");
            }
            else {
                ConsoleUtil.PrintHeader($"Редактирование контакта - {contact.FirstName} {contact.LastName}");
                PrintCommands();

                HandleCommand();
            }
        }

        public PersonEditPageProcess (string name) : base (name) {
            Commands = new Dictionary<int, ICommand>() {
                {7, new ExitCommand("Вернуться на главный экран") }
            };
        }

        private Person SearchContactByConsole () {
            var firstName = ConsoleUtil.ReadFromConsole("Введите имя контакта");
            var lastName = ConsoleUtil.ReadFromConsole("Введите фамилию контакта");
            return FindContact(firstName, lastName);
        }

        private Person FindContact (string firstName, string lastName) =>
            Storage.Instance.Contacts
                .Where(contact => contact.FirstName == firstName && contact.LastName == lastName)
                .FirstOrDefault();
    }
}
