using Coursework.commands;
using Coursework.database;
using Coursework.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.pageprocess {
    class MainPageProcess : AbstractPageProcess {
        
        public override void Run () {
            // Главное меню
            while (true) {
                ConsoleUtil.PrintHeader(Name);
                PrintCommands();
                HandleCommand();
            }
            //Сохранить данные в документ
            Storage.Instance.SaveToXml ();
        }

        public MainPageProcess (string name) : base (name) {
            //Загрузить данные из документа

            Storage.Instance.LoadFromXml ("contacts.xml");

            // Заполнить список доступных комманд
            Commands = new Dictionary<int, ICommand> () {
                {1, new PersonInfoCommand(new PersonInfoPageProcess("Просмотр информации о людях")) },
                {2, new PersonAddCommand(new PersonAddPageProcess("Добавление контакта")) },
                {3, new PersonEditCommand(new PersonEditPageProcess("Редактирование контакта")) },
                {4, new PersonDeleteCommand(new PersonDeletePageProcess("Удаление контакта")) },
                {5, new ExitCommand(new ExitPageProcess("Выход")) }
            };
        }
    }
}
