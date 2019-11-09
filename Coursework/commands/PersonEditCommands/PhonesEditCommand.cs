using Coursework.entity;
using Coursework.entity.fabrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands.PersonEditCommands {
    class PhonesEditCommand : AbstractSimpleCommand {
        public override bool Process () {
            Contact.Phones = EntityCreator.BuildPhoneList ();
            return true;
        }

        public PhonesEditCommand (string header, Person contact) : base (header, contact) { }
    }
}
