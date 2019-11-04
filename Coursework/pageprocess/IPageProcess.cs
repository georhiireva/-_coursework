using Coursework.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.pageprocess {
    interface IPageProcess {
        string Name { get; set; }
        // Метод, который запускает все, что должно происходить на текущем экране
        void Run ();

        // Метод, который реализует ввод ключа пользователем и затем выполняет соответствующую команду
        void HandleCommand ();

        // Метод, который выводит на экран доступные для текущего экрана коммнады
        void PrintCommands ();

        void PrintHello ();

        
    }
}
