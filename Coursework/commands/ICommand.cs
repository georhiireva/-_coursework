using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.commands {
    interface ICommand {

        string Name { get; set; }
        // Метод выполняет задачу, которую требует выполнить пользователь
        // Все команды по умолчанию позвращают true, и только команда Exit возвращает false
        bool Process ();


    }
}
