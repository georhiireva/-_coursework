using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework.database;
using Coursework.helpers;

namespace Coursework.commands {
    /* Класс распечатывает всю информацию обо всех контактах
     */
    class PrintInfoAllContactsCommand : AbstractSimpleCommand {

        public PrintInfoAllContactsCommand () {
            Name = "Информация о всех контактах";
        }
        public PrintInfoAllContactsCommand (string header) : base (header) { }

        public override bool Process () {
            var contacts = Storage.Instance.Contacts;
            ConsoleUtil.PrintHeader(Name);
            foreach (var contact in contacts)
                Console.WriteLine (contact);
            Console.WriteLine ();
            return true;
        }
    }
}
