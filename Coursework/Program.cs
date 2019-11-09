using Coursework.helpers;
using Coursework.pageprocess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework {
    class Program {
        static void Main (string[] args) {
            ConsoleUtil.PrintHeader ("Добро пожаловать!");
            new MainPageProcess ("ГЛАВНОЕ МЕНЮ").Run ();

            Console.ReadKey ();
        }
    }
}
