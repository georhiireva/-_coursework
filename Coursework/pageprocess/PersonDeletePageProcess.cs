using Coursework.database;
using Coursework.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.pageprocess {
    class PersonDeletePageProcess : AbstractPageProcess {

        public PersonDeletePageProcess (string name) : base (name) { }
        public override void Run () {
            var contact = StorageUtil.SearchContactByConsole ();
            Storage.Instance.Contacts.Remove (contact);
            ConsoleUtil.SimplePrint ($"Контакт {contact.FirstName} {contact.LastName} успешно удален!");
        }
    }
}
