using Coursework.pageprocess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands {
    class ExitCommand : AbstractSimpleCommand {

        public ExitCommand (string header) {
            Name = header;
        }

        public override bool Process () => false;
    }
}
