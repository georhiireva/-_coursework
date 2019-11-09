using Coursework.commands;
using Coursework.commands.PersonEditCommands;
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

        private Person Contact { get; set; }

        public override void Run () {
            ConsoleUtil.PrintHeader (Name);
            Contact = StorageUtil.SearchContactByConsole ();

            Commands = new Dictionary<int, ICommand> () {
                {1, new NameEditCommand ("Редактировать имя и фамилию", Contact) },
                {2, new BirthDateEditCommand ("Редактировать дату рождения", Contact) },
                {3, new PhonesEditCommand ("Редактировать список телефонов", Contact) },
                {4, new EmailsEditCommand ("Редактировать список адресов электронной почты", Contact) },
                {5, new AddressEditCommand ("Редактировать список почтовых адресов", Contact) },
                {6, new RemarkEditCommand ("Редактировать комментарий", Contact) },
                {7, new ExitCommand ("Вернуться на главный экран") }
            };

            if (Contact == null) {
                ConsoleUtil.PrintHeader ("Контакт не найден");
            }
            else {
                while (true) {
                    ConsoleUtil.PrintHeader ($"Редактирование контакта - {Contact.FirstName} {Contact.LastName}");
                    PrintCommands ();

                    if (!HandleCommand ())
                        break;
                }
            }

            
        }

        public PersonEditPageProcess (string name) : base (name) { }
    }
}
