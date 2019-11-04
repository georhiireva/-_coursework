using Coursework.commands;
using Coursework.database;
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


        public void PrintHello () {
            Console.WriteLine ();
            Console.WriteLine ("*****************");
            Console.WriteLine ();
            Console.WriteLine (Name);
            Console.WriteLine ();
            Console.WriteLine ("*****************");
            Console.WriteLine ();
        }

        public void PrintCommands () {
            Console.WriteLine ();
            Console.WriteLine ("Список доступных комманд");
            Console.WriteLine ();
            foreach (var entry in Commands)
                Console.WriteLine ($"{entry.Key}. {entry.Value}");
            Console.WriteLine ();
        }

        public void HandleCommand () {
            Console.WriteLine ();
            Console.WriteLine ("Введите цифру, чтобы выполнить соответствующую команду");
            Console.WriteLine ();

            int key;
            if (!int.TryParse (Console.ReadLine (), out key)) {
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
