using Coursework.pageprocess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands {
    abstract class AbstractCommand : ICommand {
        public string Name {
            get => PageProcess.Name;
            set => Name = value;
        }

        protected  IPageProcess PageProcess { get; set; }

        public AbstractCommand (IPageProcess pageProcess) {
            PageProcess = pageProcess;
        }

        public AbstractCommand (string name) {
            Name = name;
        }

        public virtual void Process () => PageProcess.Run ();

        public override string ToString () => Name;
    }
}
