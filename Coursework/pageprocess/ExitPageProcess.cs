using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.pageprocess {
    class ExitPageProcess : AbstractPageProcess {

        public ExitPageProcess (string name) : base (name) { }
        public override void Run () {
            throw new NotImplementedException ();
        }
    }
}
