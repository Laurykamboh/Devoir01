using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    class Ecole
    {
        public string Nom { get; set; }
        public int Contact { get; set; }

        public Ecole()
        {

        }

        public Ecole(string nom, int contact)
        {
            Nom = nom;
            Contact = contact;
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   Nom == ecole.Nom;
        }

        public override int GetHashCode()
        {
            return 217408413 + EqualityComparer<string>.Default.GetHashCode(Nom);
        }
    }
}
