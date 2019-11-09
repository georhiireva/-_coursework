using Coursework.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands {
    abstract class AbstractSimpleCommand : ICommand {
        public string Name { get; set; }

        public Storage Storage { get; set; }

        public AbstractSimpleCommand (string header) => Name = header;

        public AbstractSimpleCommand () { }


        public abstract bool Process ();

        public override string ToString () => Name;
    }
}
