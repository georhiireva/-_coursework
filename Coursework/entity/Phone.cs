using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.entity {
    class Phone : AbstractContactChannel {
        public Phone (string type, string value) : base (type, value) {
            RusName = "Телефон";
        }

        public Phone() {
            RusName = "Телефон";
        }

    }
}
