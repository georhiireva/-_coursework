using Coursework.entity;
using Coursework.entity.fabrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands.PersonEditCommands {
    class AddressEditCommand : AbstractSimpleCommand {
        public override bool Process () {
            Contact.Addresses = EntityCreator.BuildAddressList ();
            return true;
        }

        public AddressEditCommand (string header, Person contact) : base (header, contact) { }
    }
}
