using Coursework.entity;
using Coursework.entity.fabrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands.PersonEditCommands {
    class EmailsEditCommand : AbstractSimpleCommand {
        public override bool Process () {
            Contact.Emails = EntityCreator.BuildEmailList ();
            return true;
        }

        public EmailsEditCommand (string header, Person contact) : base (header, contact) { }
    }
}
