using Coursework.database;
using Coursework.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.pageprocess {
    // Экран добавления нового контакта
    class PersonAddPageProcess : AbstractPageProcess {

        public PersonAddPageProcess (string name) : base (name) { }
        public override void Run () {
            PrintHello ();
            Storage.Instance.Contacts.Add (Person.BuildFromConsole (new Person ()));
        }
    }
}
/* Полагаю, следует применить паттерн Абстрактная Фабрика - то есть создать абстрактный класс Фабрики,
 * Унаследовать конкретные фабрики на телефон, емэйл и адрес. Ничего им в параметры не передавать.
 */