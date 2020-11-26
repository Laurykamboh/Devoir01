using System;
using McExample.BO;
using McExample.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EtudiantBLO
    {

        EtudiantDAO etudiantRepo;

        public EtudiantBLO(string dbFolder)
        {
            etudiantRepo = new EtudiantDAO(dbFolder);
        }
        public void CreateEtudiant(Etudiant etudiant)
        {
            etudiantRepo.Remove(etudiant);
        }

        public void DeleteEtudiant(Etudiant etudiant)
        {
            etudiantRepo.Remove(etudiant);
        }
        public IEnumerable<Etudiant> GetAllEtudiants()
        {
            return etudiantRepo.Find();
        }
    }
}
