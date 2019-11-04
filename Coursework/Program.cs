using Coursework.pageprocess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("*****************");
            Console.WriteLine ();
            Console.WriteLine ("Добро пожаловать!");
            Console.WriteLine ();
            Console.WriteLine ("*****************");
            new MainPageProcess ("ГЛАВНОЕ МЕНЮ").Run ();

            Console.ReadKey ();
        }
    }
}
