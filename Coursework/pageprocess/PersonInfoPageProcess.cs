using Coursework.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.pageprocess {
    class PersonInfoPageProcess : AbstractPageProcess {

        public PersonInfoPageProcess (string name) : base (name) {
            Commands = new Dictionary<int, ICommand> () {
                {1, new PrintFioAllContactsCommand() },
                {2, new PrintInfoAllContactsCommand() }
            };

        }

        public override void Run () {
            PrintHello ();
            PrintCommands ();
            HandleCommand ();
        }
    }
}
