using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using Coursework.entity;
using System.Xml;

namespace Coursework.database {
    // Класс реализован как синглтон
    class Storage {
        private string filepath;
        private static Storage instance;
        public IList<Person> Contacts { get; set; }

        // Статическое свойство, возвращающее экземпляр класса
        public static Storage Instance {
            get {
                if (instance == null)
                    return new Storage ();
                else
                    return instance;
            }
        }
        // Приватный конструктор
        private Storage () {
            instance = this;
        }


        // Метод загружает список контактов из документа
        public void LoadFromXml (string filepath) {
            this.filepath = filepath;
            XElement xml;
            if (!File.Exists (filepath))
                new XElement (filepath).Save (filepath);

            xml = XElement.Load (filepath);

            Contacts =
               (from person in xml.Elements ()
                select new Person (
                    person.Element ("FirstName").Value,
                    person.Element ("LastName").Value,
                    DateTime.Parse (person.Element ("BirthDate").Value),
                    person.Elements ("Phone")
                        .Select (phone => new Phone (phone.Element ("Type").Value, phone.Element ("Value").Value)),
                    person.Elements ("Email")
                        .Select (email => new Email (email.Element ("Type").Value, email.Element ("Value").Value)),
                    person.Elements ("Address")
                        .Select (address => new Address (address.Element ("Type").Value, address.Element ("Value").Value)),
                    person.Element ("Remark").Value
                    )).ToList ();
        }

        // Метод записывает лист контактов в XML документ
        public void SaveToXml () {
            XElement xml = new XElement ("root",
                from person in Contacts
                select new XElement ("Person",
                    new XElement ("FirstName", person.FirstName),
                    new XElement ("LastName", person.LastName),
                    new XElement ("BirthDate", person.BirthDate),
                    from phone in person.Phones
                    select new XElement ("Phone",
                        new XElement ("Type", phone.Type),
                        new XElement ("Value", phone.Value)
                    ),
                    person.Emails
                        .Select (email => new XElement ("Email",
                              new XElement ("Type", email.Type),
                              new XElement ("Value", email.Value))
                        ),
                    from address in person.Addresses
                    select new XElement ("Address",
                        new XElement ("Type", address.Type),
                        new XElement ("Value", address.Value)
                        ),
                    new XElement ("Remark", person.Remark)
                )
            );

            xml.Save (filepath);
        }
    }
}
