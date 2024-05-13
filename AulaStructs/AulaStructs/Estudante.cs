using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaStructs {
    class Estudante {
        public string Name { get; set; }
        public string Email { get; set; } 

        public Estudante(string nome, string email) {
            Name = nome;
            Email = email;
        }

        public override string ToString() {
            return Name + ", " + Email;
        }
    }
}
