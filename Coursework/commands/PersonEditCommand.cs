using Coursework.pageprocess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands {
    class PersonEditCommand : AbstractCommand {


        public PersonEditCommand (IPageProcess pageProcess) : base (pageProcess) { }
    }
}
