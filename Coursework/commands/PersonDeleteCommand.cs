using Coursework.pageprocess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands {
    class PersonDeleteCommand : AbstractCommand {
        

        public PersonDeleteCommand (IPageProcess pageProcess) : base (pageProcess) { }
    }
}
