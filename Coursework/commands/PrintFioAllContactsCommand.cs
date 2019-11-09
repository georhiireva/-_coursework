using Coursework.database;
using Coursework.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands {
    /* Класс распечатывает ФИО всех контактов
     */
    class PrintFioAllContactsCommand : AbstractSimpleCommand {

        public PrintFioAllContactsCommand () {
            Name = "Список имен и фамилий всех контактов";
        }

        public PrintFioAllContactsCommand (string header) : base (header) { }

        public override bool Process () {
            var contacts = Storage.Instance.Contacts;
            ConsoleUtil.PrintHeader(Name);
            foreach (var contact in contacts)
                Console.WriteLine ($"{contact.FirstName} {contact.LastName}");
            Console.WriteLine ();
            return true;
        }
    }
}
