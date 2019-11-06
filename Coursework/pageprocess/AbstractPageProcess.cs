using Coursework.commands;
using Coursework.database;
using Coursework.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.pageprocess {
    abstract class AbstractPageProcess : IPageProcess {
        public  string Name { get; set; }
        // Свойство, которое содержите в себе список доступных комманд для текущего экрана
        protected IDictionary<int, ICommand> Commands { get; set; }

        public AbstractPageProcess (string name) {
            Name = name;
        }

        public abstract void Run ();

        public void PrintCommands () {

            ConsoleUtil.PrintHeader("Список доступных команд");

            foreach (var entry in Commands)
                Console.WriteLine ($"{entry.Key}. {entry.Value}");
            Console.WriteLine ();
        }

        public void HandleCommand () {

            var userInput = ConsoleUtil.ReadFromConsole("Введите цифру, чтобы выполнить соответствующую команду");

            int key;
            if (!int.TryParse (userInput, out key)) {
                Console.WriteLine ();
                Console.WriteLine ("Вы ошиблись при вводе, попробуйте еще раз");
                Console.WriteLine ();
                HandleCommand ();
            }
            
            Commands[key].Process ();
            Console.WriteLine ();
        }
    }
}
