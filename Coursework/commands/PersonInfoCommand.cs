using Coursework.pageprocess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands {
    class PersonInfoCommand : AbstractCommand {

        
        public PersonInfoCommand (IPageProcess pageProcess) : base (pageProcess) { }
    }
}
