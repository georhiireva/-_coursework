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


        public abstract void Process ();

        public override string ToString () => Name;

        public void PrintHello () {
            Console.WriteLine ();
            Console.WriteLine ("*****************");
            Console.WriteLine ();
            Console.WriteLine (Name);
            Console.WriteLine ();
            Console.WriteLine ("*****************");
            Console.WriteLine ();
        }
    }
}
