using Coursework.pageprocess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands {
    class ExitCommand : AbstractCommand {

        public ExitCommand (IPageProcess pageProcess) : base (pageProcess) { }

        public override bool Process () => false;
    }
}
