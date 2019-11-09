using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands.PersonEditCommands {
    class EmailsEditCommand : AbstractSimpleCommand {
        public override bool Process () {
            throw new NotImplementedException();
        }

        public EmailsEditCommand (string header) : base (header) { }
    }
}
