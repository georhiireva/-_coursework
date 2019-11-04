using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.entity {
    class Address : AbstractContactChannel {
        public Address (string type, string value) : base (type, value) {
            RusName = "Адрес";
        }

        public Address () {
            RusName = "Адрес";
        }
    }
}
