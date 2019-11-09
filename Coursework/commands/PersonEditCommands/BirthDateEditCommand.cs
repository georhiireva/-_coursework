using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands.PersonEditCommands {
    class BirthDateEditCommand : AbstractSimpleCommand {
        public override bool Process () {
            throw new NotImplementedException();
        }

        public BirthDateEditCommand (string header) : base (header) { }
    }
}
