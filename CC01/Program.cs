using System;
using McExample.BLL;
using McExample.BO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "o";
            do
            {
                Console.WriteLine("..................Creer un etudiant..............");
                Console.Write("Entrer le matricule: \t");
                string Matricule = Console.ReadLine();
                Console.Write("Entrer le nom de l'étudiant: \t");
                string Nom = Console.ReadLine();
                Console.Write("Entrer le prenom de l'étudiant: \t");
                string Prenom = Console.ReadLine();
                Console.Write("Entrer le numero de l'étudiant: \t");
                int Contact = int.Parse(Console.ReadLine());
                Console.Write("Entrer l'etablissement de l'étudiant: \t");
                string Ecolecourante = Console.ReadLine();
                Console.Write("Entrer la date de naissance de l'etudiant de l'étudiant: \t");
                string Datedenaissance = Console.ReadLine();

                EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
                Etudiant etudiant = new Etudiant(Matricule, Nom, Prenom, Contact, Ecolecourante, Datedenaissance);

                etudiantBLO.CreateEtudiant(etudiant);

                IEnumerable<Etudiant> etudiants = etudiantBLO.GetAllEtudiants();
                foreach (Etudiant e in etudiants)
                {
                    Console.WriteLine($"{e.Matricule}\t{e.Nom}");
                }

                Console.Write("Creer un autre etudiant?[o/n]:");


                //etudiants = etudiantBLO.GetAllEtudiants();
                //foreach (Etudiant e in etudiants)
                //{
                //  Console.WriteLine($"{e.Matricule}\t{e.Nom}");
                //}


                choice = Console.ReadLine();
            } while (choice.ToLower() == "o");

            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
    }
}
