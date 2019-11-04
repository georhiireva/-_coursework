using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.entity {
    class Email : AbstractContactChannel {
        public Email (string type, string value) : base (type, value) {
            RusName = "Электронная почта";
        }

        public Email () {
            RusName = "Электронная почта";
        }
    }
}
