using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework.database;

namespace Coursework.commands {
    /* Класс распечатывает всю информацию обо всех контактах
     */
    class PrintInfoAllContactsCommand : AbstractSimpleCommand {

        public PrintInfoAllContactsCommand () {
            Name = "Информация о всех контактах";
        }
        public override void Process () {
            var contacts = Storage.Instance.Contacts;
            PrintHello ();
            foreach (var contact in contacts)
                Console.WriteLine (contact);
            Console.WriteLine ();
        }
    }
}
