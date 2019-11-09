using Coursework.entity;
using Coursework.entity.fabrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands.PersonEditCommands {
    class NameEditCommand : AbstractSimpleCommand {
        public override bool Process () {
            Contact.FirstName = EntityCreator.BuildFirstName ();
            Contact.LastName = EntityCreator.BuildLastName ();
            return true;
        }

        public NameEditCommand (string header, Person contact) : base (header, contact) { }
        
    }
}
