using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]

    public class Etudiant
    {
       

        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Contact { get; set; }
        public string Ecole { get; set; }

        public Etudiant()
        {

        }

        public Etudiant(string matricule, string nom, string prenom, int contact, string ecole)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            Contact = contact;
            Ecole = ecole;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Matricule == etudiant.Matricule;
        }

        public override int GetHashCode()
        {
            return 797189699 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }
    }
}
