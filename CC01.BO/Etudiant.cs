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
        public string Ecolecourante { get; set; }

        public string Ecolecourante { get; set; }

        public Etudiant(string matricule, string nom, string prenom, int contact, string datedenaissance, string ecolecourante)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            this.Contact = contact;
            Datedenaissance = datedenaissance;
            Ecolecourante = ecolecourante;
        }

        public Etudiant()
        {
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
