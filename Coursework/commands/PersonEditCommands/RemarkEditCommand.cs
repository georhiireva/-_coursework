using Coursework.entity;
using Coursework.entity.fabrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands.PersonEditCommands {
    class RemarkEditCommand : AbstractSimpleCommand {
        public override bool Process () {
            Contact.Remark = EntityCreator.BuildRemark ();
            return true;
        }

        public RemarkEditCommand (string header, Person contact) : base (header, contact) { }
    }
}
