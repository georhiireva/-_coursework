using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.helpers {
    class ConsoleUtil {
        public static string ReadFromConsole (string header) {
            Console.WriteLine();
            Console.WriteLine(header);
            Console.WriteLine();
            return Console.ReadLine();
        }

        public static void PrintHeader (string header) {
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine();
            Console.WriteLine(header);
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine();
        }

        public static void SimplePrint (string header) {
            Console.WriteLine ();
            Console.WriteLine (header);
            Console.WriteLine ();
        }
    }
}
