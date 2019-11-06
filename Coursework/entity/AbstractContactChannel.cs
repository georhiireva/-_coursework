using Coursework.helpers;
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
            ConsoleUtil.PrintHeader($"Добавление нового {obj.RusName}");
            ConsoleUtil.PrintHeader("Для выхода введите -1 в любое время");

            var type = ConsoleUtil.ReadFromConsole("Введите тип");
            if (type == "-1")
                return null;
            obj.Type = type;

            var value = ConsoleUtil.ReadFromConsole("Введите значение");
            if (value == "-1")
                return null;
            obj.Value = value;

            return obj;
        }
    }
}
