using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.entity {
    abstract class AbstractContactChannel {
        public string Type { get; set; }
        public string Value { get; set; }
        public string RusName { get; set; }

        public AbstractContactChannel (string type, string value) {
            Type = type;
            Value = value;
        }

        public AbstractContactChannel () { }
        public static AbstractContactChannel BuildFromConsole (AbstractContactChannel obj) {
            PrintHello ($"Добавление нового {obj.RusName}");
            Console.WriteLine ("Для выхода введите -1 в любое время");
            Console.WriteLine ();
            Console.WriteLine ("Введите тип");
            Console.WriteLine ();

            var type = Console.ReadLine ();
            if (type == "-1")
                return null;
            obj.Type = type;

            Console.WriteLine ();
            Console.WriteLine ("Введите значение");
            Console.WriteLine ();

            var value = Console.ReadLine ();
            if (value == "-1")
                return null;
            obj.Value = value;

            return obj;
        }

        public static void PrintHello (string name) {
            Console.WriteLine ();
            Console.WriteLine ("*****************");
            Console.WriteLine ();
            Console.WriteLine (name);
            Console.WriteLine ();
            Console.WriteLine ("*****************");
            Console.WriteLine ();
        }
    }
}
