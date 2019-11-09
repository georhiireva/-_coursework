using Coursework.entity;
using Coursework.entity.fabrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands.PersonEditCommands {
    class BirthDateEditCommand : AbstractSimpleCommand {
        public override bool Process () {
            Contact.BirthDate = EntityCreator.BuildBirthDate ();
            return true;
        }

        public BirthDateEditCommand (string header, Person contact) : base (header, contact) { }
    }
}
